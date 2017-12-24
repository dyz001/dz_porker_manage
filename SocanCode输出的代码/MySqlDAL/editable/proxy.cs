using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 proxy
    /// <summary>
    public partial class proxy : DALHelper
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.proxy model)
        {
            IDbDataParameter[] parms4proxy = PrepareAddParameters(model);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_ADD, parms4proxy);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.proxy model)
        {
            IDbDataParameter[] parms4proxy = PrepareUpdateParameters(model);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_UPDATE, parms4proxy);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int? id)
        {
            IDbDataParameter[] parms4proxy = PrepareDeleteParameters(id);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_DELETE, parms4proxy);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.proxy GetModel(int? id)
        {
            IDbDataParameter[] parms4proxy = PrepareGetModelParameters(id);
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETMODEL, parms4proxy))
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
            IDbDataParameter[] parms4proxy = PrepareExistParameters(id);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, COMMAND_EXISTS, parms4proxy);
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
        public List<Model.proxy> GetList()
        {
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETLIST, null))
            {
                List<Model.proxy> lst = new List<Model.proxy>();
                ExecuteReaderAction(dr, r => lst.Add(GetModel(r)));
                return lst;
            }
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.proxy> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();

            PageList<Model.proxy> pl = new PageList<Model.proxy>(pi);
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETLIST, null))
            {
                pl.List = new List<Model.proxy>();
                ExecuteReaderAction(dr, pi.FirstIndex, pi.PageSize, r => pl.List.Add(GetModel(r)));
            }
            return pl;
        }

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Model.proxy GetModel(IDataReader dr)
        {
            Model.proxy model = new Model.proxy();
            PrepareModel(model, dr);
            return model;
        }
    }
}