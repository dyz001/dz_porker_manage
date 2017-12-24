using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 choushui
    /// <summary>
    public partial class choushui : DALHelper
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.choushui model)
        {
            IDbDataParameter[] parms4choushui = PrepareAddParameters(model);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_ADD, parms4choushui);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.choushui model)
        {
            IDbDataParameter[] parms4choushui = PrepareUpdateParameters(model);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_UPDATE, parms4choushui);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int? id)
        {
            IDbDataParameter[] parms4choushui = PrepareDeleteParameters(id);
            return dbHelper.ExecuteNonQuery(CommandType.Text, COMMAND_DELETE, parms4choushui);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.choushui GetModel(int? id)
        {
            IDbDataParameter[] parms4choushui = PrepareGetModelParameters(id);
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETMODEL, parms4choushui))
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
            IDbDataParameter[] parms4choushui = PrepareExistParameters(id);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, COMMAND_EXISTS, parms4choushui);
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
        public List<Model.choushui> GetList()
        {
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETLIST, null))
            {
                List<Model.choushui> lst = new List<Model.choushui>();
                ExecuteReaderAction(dr, r => lst.Add(GetModel(r)));
                return lst;
            }
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.choushui> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();

            PageList<Model.choushui> pl = new PageList<Model.choushui>(pi);
            using (IDataReader dr = dbHelper.ExecuteReader(CommandType.Text, COMMAND_GETLIST, null))
            {
                pl.List = new List<Model.choushui>();
                ExecuteReaderAction(dr, pi.FirstIndex, pi.PageSize, r => pl.List.Add(GetModel(r)));
            }
            return pl;
        }

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Model.choushui GetModel(IDataReader dr)
        {
            Model.choushui model = new Model.choushui();
            PrepareModel(model, dr);
            return model;
        }
    }
}