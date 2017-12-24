using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DBUtility;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 choushui ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class choushui
    {
        internal const string COMMAND_ADD = "INSERT INTO choushui(cs_type, cs_value) VALUES (@in_cs_type, @in_cs_value)";
        internal const string COMMAND_UPDATE = "UPDATE choushui SET cs_type=@in_cs_type, cs_value=@in_cs_value WHERE id=@in_id";
        internal const string COMMAND_DELETE = "DELETE FROM choushui WHERE id=@in_id";
        internal const string COMMAND_EXISTS = "SELECT COUNT(1) FROM choushui WHERE id=@in_id";
        internal const string COMMAND_GETMODEL = "SELECT * FROM choushui WHERE id=@in_id";
        internal const string COMMAND_GETCOUNT = "SELECT COUNT(*) FROM choushui";
        internal const string COMMAND_GETLIST = "SELECT * FROM choushui";

        internal const string PARM_ID = "@in_id";
        internal const string PARM_CS_TYPE = "@in_cs_type";
        internal const string PARM_CS_VALUE = "@in_cs_value";

        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareAddParameters(Model.choushui model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_ADD);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_CS_TYPE, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CS_VALUE, DbType.Double, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_ADD, parms);
            }

            parms[0].Value = model.cs_type;
            parms[1].Value = model.cs_value;

            return parms;
        }

        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareUpdateParameters(Model.choushui model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_CS_TYPE, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CS_VALUE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE, parms);
            }

            parms[0].Value = model.cs_type;
            parms[1].Value = model.cs_value;
            parms[2].Value = model.id;

            return parms;
        }

        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareDeleteParameters(int? id)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_DELETE);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_EXISTS, parms);
            }

            parms[0].Value = id;

            return parms;
        }

        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareExistParameters(int? id)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_EXISTS);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_EXISTS, parms);
            }

            parms[0].Value = id;

            return parms;
        }

        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareGetModelParameters(int? id)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_GETMODEL);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_EXISTS, parms);
            }

            parms[0].Value = id;

            return parms;
        }

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.choushui model, IDataReader dr)
        {
            model.id = DbValue.GetInt(dr["id"]);
            model.cs_type = DbValue.GetString(dr["cs_type"]);
            model.cs_value = DbValue.GetDouble(dr["cs_value"]);
        }
    }
}
