using dz_manager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YZ.Utils;

namespace DataInput.DBOper
{
    public class DBUtil
    {
        protected MySqlConnection m_mysqlConn;
        protected const string m_connFormatStr = "server={0};uid={1};pwd={2};database={3};port={4};";
        //protected const string m_create
        protected static DBUtil m_Instance;
        protected MySqlCommand m_myCommand;
        protected MySqlDataReader m_myReader;
        MySqlDataAdapter m_myAdapter;
        protected static dz_manager.DBConfig.DBAuthData m_auth_data;
        protected bool m_bStationDirty = true;

        public static void SetMysqlAuth(dz_manager.DBConfig.DBAuthData auth_data)
        {
            m_auth_data = auth_data;
        }
        public static DBUtil GetInstance()
        {
            if(m_Instance == null)
            {
                m_Instance = new DBUtil();
                m_Instance.InitData();
            }
            return m_Instance;
        }

        protected void InitData()
        {
            dz_manager.DBConfig.DBAuthData auth_data = m_auth_data;
            if (auth_data == null) return;
            //m_lstStation = new List<station>();
            if(m_mysqlConn == null)
            {
                string connStr = string.Format(m_connFormatStr, auth_data.DBHost, auth_data.DBUser, Tools.Decrypt(auth_data.DBPass), auth_data.DBName, auth_data.DBPort);
                m_mysqlConn = new MySqlConnection(connStr);
            }
            m_myAdapter = new MySqlDataAdapter();
        }

        public void CloseConnection()
        {
            if (m_mysqlConn.State == ConnectionState.Open)
            {
                m_mysqlConn.Close();
            }
        }

        public static bool TryOpenDB(dz_manager.DBConfig.DBAuthData auth_data)
        {
            bool ret = true;
            string connStr = string.Format(m_connFormatStr, auth_data.DBHost, auth_data.DBUser, Tools.Decrypt(auth_data.DBPass), auth_data.DBName, auth_data.DBPort);
            MySqlConnection con = new MySqlConnection(connStr);
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            con.Close();
            return ret;
        }
    
        protected bool ExcuteNoQuery(string sql)
        {
            if(m_mysqlConn.IsPasswordExpired)
            {
                
            }
            m_myCommand.CommandText = sql;
            m_myCommand.CommandType = System.Data.CommandType.Text;
            return m_myCommand.ExecuteNonQuery() > 0;
        }
        public bool AddNewVoyage(string ItemName, string Member, string TimeRange, string Power, double Length, double Width, int SurveyItems)
        {
            return true;
        }

        public IList<T> GetLstBySql<T>(string sql)where T:class
        {
            BeginTrans();
            IList<T> ret = new List<T>();
            m_myCommand.CommandText = sql;
            m_myCommand.CommandType = CommandType.Text;
            m_myReader = m_myCommand.ExecuteReader();
            ret = DataHelper.ConvertToLst<T>(m_myReader);
            EndTrans();
            return ret;
        }

        public IList<T> GetLstItems<T>()where T:class
        {   
            string sql = "select * from " + typeof(T).Name;
            return GetLstBySql<T>(sql);
        }

        public IList<T> GetLstItems<T>(string where, int count = 0)where T:class
        {
            string sql = "";
            if (count > 0)
            {
                sql = "select " + " * from " + typeof(T).Name + " where " + where + " limit " + count;
            }
            else
            {
                sql = "select * from " + typeof(T).Name + " where " + where;
            }
            return GetLstBySql<T>(sql);
        }

        public bool CheckExistByWhere<T>(string where = "")
        {
            bool ret = false;
            BeginTrans();
            m_myCommand.CommandText = "select id from " + typeof(T).Name + (string.IsNullOrEmpty(where) ? "" : " where " + where);
            m_myReader = m_myCommand.ExecuteReader();
            if(m_myReader.HasRows)
            {
                ret = true;
            }
            EndTrans();
            return ret;
        }

        public T GetEntityByWhere<T>(string where) where T : class
        {
            T ret = default(T);
            BeginTrans();
            m_myCommand.CommandText = "select * from " + typeof(T).Name + (string.IsNullOrEmpty(where) ?
                "" : " where " + where);
            DataSet MyDataSet = new DataSet();
            m_myAdapter.SelectCommand = m_myCommand;
            m_myAdapter.Fill(MyDataSet, "DataSet1"); 
            m_myCommand.CommandType = CommandType.Text;
            if(MyDataSet.Tables.Count > 0 && MyDataSet.Tables[0].Rows.Count > 0)
            {
                ret = DataHelper.ConvertToEntity<T>(MyDataSet.Tables[0].Rows[0]);
            }
            //m_myReader = m_myCommand.ExecuteReader();
            //if (m_myReader.Read())
            //{
            //    ret = DataHelper.ConvertToEntity<T>(m_myReader);
            //}
            EndTrans();
            return ret;
        }

        public T GetEntityBySql<T>(string sql) where T : class
        {
            BeginTrans();
            IList<T> ret;
            m_myCommand.CommandText = sql;
            m_myCommand.CommandType = CommandType.Text;
            DataSet MyDataSet = new DataSet();
            m_myAdapter.SelectCommand = m_myCommand;
            m_myAdapter.Fill(MyDataSet, "DataSet1"); 
            ret = DataHelper.ConvertToLst<T>(MyDataSet);
            EndTrans();
            if(ret.Count == 0)
            {
                return default(T);
            }
            return ret[0];
        }

        public void BeginTrans()
        {
            if (m_mysqlConn.State == ConnectionState.Closed ||
                m_mysqlConn.State == ConnectionState.Broken)
            {
                m_mysqlConn.Open();
            }
            m_myCommand = new MySqlCommand();
            m_myCommand.Connection = m_mysqlConn;
        }

        public void EndTrans()
        {
            //m_mysqlConn.Close();
            if(m_myReader != null && !m_myReader.IsClosed)
                m_myReader.Close();
        }

        public bool CheckAndAdd<T>(string where, T ins)
        {
            try
            {
                if (CheckExist<T>(where))
                {
                    if (!Update<T>(ins))
                        return false;
                }
                else
                {
                    if (!SaveObj<T>(ins))
                        return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public bool CheckExist<T>(string where)
        {
            BeginTrans();
            bool ret = false;
            try
            {
                m_myCommand.CommandText = "select Id from " + typeof(T).Name + " where " + where;
                m_myCommand.CommandType = CommandType.Text;
                m_myReader = m_myCommand.ExecuteReader();
                if (m_myReader.Read())
                {
                    ret = true;
                }
                else
                    ret = false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                EndTrans();
            }
            return ret;
        }

        public int GetLastId()
        {
            BeginTrans();
            int lastId = 0;
            m_myCommand.CommandText = "select @@IDENTITY";
            m_myCommand.CommandType = CommandType.Text;
            m_myReader = m_myCommand.ExecuteReader();
            if (m_myReader.Read())
            {
                lastId = m_myReader.GetInt32(0);
            }
            else
            {
                lastId = 0;
            }
            EndTrans();
            return lastId;
        }

        public bool SaveObj<T>(T ins)
        {
            BeginTrans();
            int ret = 0;
            try
            {
                m_myCommand.CommandText = DataHelper.GenInsertSql<T>(ins);
                m_myCommand.CommandType = CommandType.Text;
                ret = m_myCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                ret = 0;
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                EndTrans();
            }
            return ret > 0;
        }

        public int UpdateItems<T>(string set_condition, string where = "")
        {
            BeginTrans();
            int ret = 0;
            try
            {
                string sql = "";
                if(string.IsNullOrEmpty(set_condition))
                {
                    return 0;
                }
                if(string.IsNullOrEmpty(where))
                {
                    sql = "update " + typeof(T).Name + " set " + set_condition;
                }
                else
                {
                    sql = "update " + typeof(T).Name + " set " + set_condition + " where " + where;
                }
                m_myCommand.CommandText = sql;
                m_myCommand.CommandType = CommandType.Text;
                ret = m_myCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                EndTrans();
            }
            return ret;
        }

        public bool Update<T>(T ins)
        {
            BeginTrans();
            int ret = 0;
            try
            {
                m_myCommand.CommandText = DataHelper.GenUpdateSql<T>(ins);
                m_myCommand.CommandType = CommandType.Text;
                ret = m_myCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                EndTrans();
            }
            return ret > 0;
        }

        public int Delete<T>(string where = "")
        {
            int ret = 0;
            BeginTrans();
            try
            {
                string sql = ""; 
                if(string.IsNullOrEmpty(where))
                {
                    sql = "delete from " + typeof(T).Name;
                }
                else
                {
                    sql = "delete from " + typeof(T).Name + " where " + where;
                }
                m_myCommand.CommandText = sql;
                m_myCommand.CommandType = CommandType.Text;
                ret = m_myCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                EndTrans();
            }
            return ret;
        }

        public void SetStationDirty(bool param)
        {
            m_bStationDirty = param;
        }
    }
}
