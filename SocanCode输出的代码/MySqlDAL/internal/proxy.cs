using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DBUtility;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 proxy ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class proxy
    {
        internal const string COMMAND_ADD = "INSERT INTO proxy(name, no, fs_type, optor, oper_time) VALUES (@in_name, @in_no, @in_fs_type, @in_optor, @in_oper_time)";
        internal const string COMMAND_UPDATE = "UPDATE proxy SET name=@in_name, no=@in_no, fs_type=@in_fs_type, optor=@in_optor, oper_time=@in_oper_time WHERE id=@in_id";
        internal const string COMMAND_DELETE = "DELETE FROM proxy WHERE id=@in_id";
        internal const string COMMAND_EXISTS = "SELECT COUNT(1) FROM proxy WHERE id=@in_id";
        internal const string COMMAND_GETMODEL = "SELECT * FROM proxy WHERE id=@in_id";
        internal const string COMMAND_GETCOUNT = "SELECT COUNT(*) FROM proxy";
        internal const string COMMAND_GETLIST = "SELECT * FROM proxy";

        internal const string PARM_ID = "@in_id";
        internal const string PARM_NAME = "@in_name";
        internal const string PARM_NO = "@in_no";
        internal const string PARM_FS_TYPE = "@in_fs_type";
        internal const string PARM_OPTOR = "@in_optor";
        internal const string PARM_OPER_TIME = "@in_oper_time";

        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareAddParameters(Model.proxy model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_ADD);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_NO, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_FS_TYPE, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPER_TIME, DbType.DateTime, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_ADD, parms);
            }

            parms[0].Value = model.name;
            parms[1].Value = model.no;
            parms[2].Value = model.fs_type;
            parms[3].Value = model.optor;
            parms[4].Value = model.oper_time;

            return parms;
        }

        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareUpdateParameters(Model.proxy model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_NO, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_FS_TYPE, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPER_TIME, DbType.DateTime, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE, parms);
            }

            parms[0].Value = model.name;
            parms[1].Value = model.no;
            parms[2].Value = model.fs_type;
            parms[3].Value = model.optor;
            parms[4].Value = model.oper_time;
            parms[5].Value = model.id;

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
        internal static void PrepareModel(Model.proxy model, IDataReader dr)
        {
            model.id = DbValue.GetInt(dr["id"]);
            model.name = DbValue.GetString(dr["name"]);
            model.no = DbValue.GetString(dr["no"]);
            model.fs_type = DbValue.GetString(dr["fs_type"]);
            model.optor = DbValue.GetString(dr["optor"]);
            model.oper_time = DbValue.GetDateTime(dr["oper_time"]);
        }
    }
}
