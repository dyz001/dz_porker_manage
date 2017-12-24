using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 desk
    /// <summary>
    public partial class desk : DALHelper
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.desk model)
        {
            IDbDataParameter[] parms4desk = PrepareAddParameters(model);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_ADD, parms4desk);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.desk model)
        {
            IDbDataParameter[] parms4desk = PrepareUpdateParameters(model);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_UPDATE, parms4desk);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int? id)
        {
            IDbDataParameter[] parms4desk = PrepareDeleteParameters(id);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_DELETE, parms4desk);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.desk GetModel(int? id)
        {
            IDbDataParameter[] parms4desk = PrepareGetModelParameters(id);
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETMODEL, parms4desk))
            {
                if (dr.Read()) return GetModel(dr);
                return null;
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? id)
        {
            IDbDataParameter[] parms4desk = PrepareExistParameters(id);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, COMMAND_EXISTS, parms4desk);
            return int.Parse(obj.ToString()) > 0;
        }

        /// <summary>
        /// 获取数量
        /// </summary>
        public int GetCount()
        {
            object obj = dbHelper.ExecuteScalar(CommandType.Text, COMMAND_GETCOUNT, null);
            return int.Parse(obj.ToString());
        }

        /// <summary>
        /// 获取泛型数据列表
        /// </summary>
        public List<Model.desk> GetList()
        {
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETLIST, null))
            {
                List<Model.desk> lst = new List<Model.desk>();
                ExecuteReaderAction(dr, r => lst.Add(GetModel(r)));
                return lst;
            }
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.desk> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();

            PageList<Model.desk> pl = new PageList<Model.desk>(pi);
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETLIST, null))
            {
                pl.List = new List<Model.desk>();
                ExecuteReaderAction(dr, pi.FirstIndex, pi.PageSize, r => pl.List.Add(GetModel(r)));
            }
            return pl;
        }

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Model.desk GetModel(IDataReader dr)
        {
            Model.desk model = new Model.desk();
            PrepareModel(model, dr);
            return model;
        }
    }
}