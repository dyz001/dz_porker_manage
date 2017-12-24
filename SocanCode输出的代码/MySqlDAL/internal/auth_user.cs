using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DBUtility;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 auth_user ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class auth_user
    {
        internal const string COMMAND_ADD = "INSERT INTO auth_user(username, password, auth_type) VALUES (@in_username, @in_password, @in_auth_type)";
        internal const string COMMAND_UPDATE = "UPDATE auth_user SET username=@in_username, password=@in_password, auth_type=@in_auth_type WHERE id=@in_id";
        internal const string COMMAND_DELETE = "DELETE FROM auth_user WHERE id=@in_id";
        internal const string COMMAND_EXISTS = "SELECT COUNT(1) FROM auth_user WHERE id=@in_id";
        internal const string COMMAND_GETMODEL = "SELECT * FROM auth_user WHERE id=@in_id";
        internal const string COMMAND_GETCOUNT = "SELECT COUNT(*) FROM auth_user";
        internal const string COMMAND_GETLIST = "SELECT * FROM auth_user";

        internal const string PARM_ID = "@in_id";
        internal const string PARM_USERNAME = "@in_username";
        internal const string PARM_PASSWORD = "@in_password";
        internal const string PARM_AUTH_TYPE = "@in_auth_type";

        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareAddParameters(Model.auth_user model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_ADD);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_USERNAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_PASSWORD, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_AUTH_TYPE, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_ADD, parms);
            }

            parms[0].Value = model.username;
            parms[1].Value = model.password;
            parms[2].Value = model.auth_type;

            return parms;
        }

        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareUpdateParameters(Model.auth_user model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_USERNAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_PASSWORD, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_AUTH_TYPE, DbType.Int32, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE, parms);
            }

            parms[0].Value = model.username;
            parms[1].Value = model.password;
            parms[2].Value = model.auth_type;
            parms[3].Value = model.id;

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
        internal static void PrepareModel(Model.auth_user model, IDataReader dr)
        {
            model.id = DbValue.GetInt(dr["id"]);
            model.username = DbValue.GetString(dr["username"]);
            model.password = DbValue.GetString(dr["password"]);
            model.auth_type = DbValue.GetInt(dr["auth_type"]);
        }
    }
}
