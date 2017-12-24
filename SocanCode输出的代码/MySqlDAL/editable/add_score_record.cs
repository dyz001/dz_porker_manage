using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 add_score_record
    /// <summary>
    public partial class add_score_record : DALHelper
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.add_score_record model)
        {
            IDbDataParameter[] parms4add_score_record = PrepareAddParameters(model);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_ADD, parms4add_score_record);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.add_score_record model)
        {
            IDbDataParameter[] parms4add_score_record = PrepareUpdateParameters(model);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_UPDATE, parms4add_score_record);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int? id)
        {
            IDbDataParameter[] parms4add_score_record = PrepareDeleteParameters(id);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_DELETE, parms4add_score_record);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.add_score_record GetModel(int? id)
        {
            IDbDataParameter[] parms4add_score_record = PrepareGetModelParameters(id);
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETMODEL, parms4add_score_record))
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
            IDbDataParameter[] parms4add_score_record = PrepareExistParameters(id);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, COMMAND_EXISTS, parms4add_score_record);
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
        public List<Model.add_score_record> GetList()
        {
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETLIST, null))
            {
                List<Model.add_score_record> lst = new List<Model.add_score_record>();
                ExecuteReaderAction(dr, r => lst.Add(GetModel(r)));
                return lst;
            }
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.add_score_record> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();

            PageList<Model.add_score_record> pl = new PageList<Model.add_score_record>(pi);
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETLIST, null))
            {
                pl.List = new List<Model.add_score_record>();
                ExecuteReaderAction(dr, pi.FirstIndex, pi.PageSize, r => pl.List.Add(GetModel(r)));
            }
            return pl;
        }

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Model.add_score_record GetModel(IDataReader dr)
        {
            Model.add_score_record model = new Model.add_score_record();
            PrepareModel(model, dr);
            return model;
        }
    }
}