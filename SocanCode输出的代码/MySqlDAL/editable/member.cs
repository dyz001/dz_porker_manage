using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 member
    /// <summary>
    public partial class member : DALHelper
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.member model)
        {
            IDbDataParameter[] parms4member = PrepareAddParameters(model);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_ADD, parms4member);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.member model)
        {
            IDbDataParameter[] parms4member = PrepareUpdateParameters(model);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_UPDATE, parms4member);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int? id)
        {
            IDbDataParameter[] parms4member = PrepareDeleteParameters(id);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_DELETE, parms4member);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.member GetModel(int? id)
        {
            IDbDataParameter[] parms4member = PrepareGetModelParameters(id);
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETMODEL, parms4member))
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
            IDbDataParameter[] parms4member = PrepareExistParameters(id);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, COMMAND_EXISTS, parms4member);
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
        public List<Model.member> GetList()
        {
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETLIST, null))
            {
                List<Model.member> lst = new List<Model.member>();
                ExecuteReaderAction(dr, r => lst.Add(GetModel(r)));
                return lst;
            }
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.member> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();

            PageList<Model.member> pl = new PageList<Model.member>(pi);
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETLIST, null))
            {
                pl.List = new List<Model.member>();
                ExecuteReaderAction(dr, pi.FirstIndex, pi.PageSize, r => pl.List.Add(GetModel(r)));
            }
            return pl;
        }

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Model.member GetModel(IDataReader dr)
        {
            Model.member model = new Model.member();
            PrepareModel(model, dr);
            return model;
        }
    }
}