using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DBUtility;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 fanshui ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class fanshui
    {
        internal const string COMMAND_ADD = "INSERT INTO fanshui(fs_type, fs_value) VALUES (@in_fs_type, @in_fs_value)";
        internal const string COMMAND_UPDATE = "UPDATE fanshui SET fs_type=@in_fs_type, fs_value=@in_fs_value WHERE id=@in_id";
        internal const string COMMAND_DELETE = "DELETE FROM fanshui WHERE id=@in_id";
        internal const string COMMAND_EXISTS = "SELECT COUNT(1) FROM fanshui WHERE id=@in_id";
        internal const string COMMAND_GETMODEL = "SELECT * FROM fanshui WHERE id=@in_id";
        internal const string COMMAND_GETCOUNT = "SELECT COUNT(*) FROM fanshui";
        internal const string COMMAND_GETLIST = "SELECT * FROM fanshui";

        internal const string PARM_ID = "@in_id";
        internal const string PARM_FS_TYPE = "@in_fs_type";
        internal const string PARM_FS_VALUE = "@in_fs_value";

        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareAddParameters(Model.fanshui model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_ADD);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_FS_TYPE, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_FS_VALUE, DbType.Double, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_ADD, parms);
            }

            parms[0].Value = model.fs_type;
            parms[1].Value = model.fs_value;

            return parms;
        }

        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareUpdateParameters(Model.fanshui model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_FS_TYPE, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_FS_VALUE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE, parms);
            }

            parms[0].Value = model.fs_type;
            parms[1].Value = model.fs_value;
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
        internal static void PrepareModel(Model.fanshui model, IDataReader dr)
        {
            model.id = DbValue.GetInt(dr["id"]);
            model.fs_type = DbValue.GetString(dr["fs_type"]);
            model.fs_value = DbValue.GetDouble(dr["fs_value"]);
        }
    }
}
