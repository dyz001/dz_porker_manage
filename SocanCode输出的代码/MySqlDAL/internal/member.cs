using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DBUtility;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 member ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class member
    {
        internal const string COMMAND_ADD = "INSERT INTO member(game_id, wx_id, ali_id, proxy_id, cs_type, first_balance, balance, optor, oper_time) VALUES (@in_game_id, @in_wx_id, @in_ali_id, @in_proxy_id, @in_cs_type, @in_first_balance, @in_balance, @in_optor, @in_oper_time)";
        internal const string COMMAND_UPDATE = "UPDATE member SET game_id=@in_game_id, wx_id=@in_wx_id, ali_id=@in_ali_id, proxy_id=@in_proxy_id, cs_type=@in_cs_type, first_balance=@in_first_balance, balance=@in_balance, optor=@in_optor, oper_time=@in_oper_time WHERE id=@in_id";
        internal const string COMMAND_DELETE = "DELETE FROM member WHERE id=@in_id";
        internal const string COMMAND_EXISTS = "SELECT COUNT(1) FROM member WHERE id=@in_id";
        internal const string COMMAND_GETMODEL = "SELECT * FROM member WHERE id=@in_id";
        internal const string COMMAND_GETCOUNT = "SELECT COUNT(*) FROM member";
        internal const string COMMAND_GETLIST = "SELECT * FROM member";

        internal const string PARM_ID = "@in_id";
        internal const string PARM_GAME_ID = "@in_game_id";
        internal const string PARM_WX_ID = "@in_wx_id";
        internal const string PARM_ALI_ID = "@in_ali_id";
        internal const string PARM_PROXY_ID = "@in_proxy_id";
        internal const string PARM_CS_TYPE = "@in_cs_type";
        internal const string PARM_FIRST_BALANCE = "@in_first_balance";
        internal const string PARM_BALANCE = "@in_balance";
        internal const string PARM_OPTOR = "@in_optor";
        internal const string PARM_OPER_TIME = "@in_oper_time";

        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareAddParameters(Model.member model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_ADD);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_GAME_ID, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_WX_ID, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ALI_ID, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_PROXY_ID, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CS_TYPE, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_FIRST_BALANCE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_BALANCE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPER_TIME, DbType.DateTime, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_ADD, parms);
            }

            parms[0].Value = model.game_id;
            parms[1].Value = model.wx_id;
            parms[2].Value = model.ali_id;
            parms[3].Value = model.proxy_id;
            parms[4].Value = model.cs_type;
            parms[5].Value = model.first_balance;
            parms[6].Value = model.balance;
            parms[7].Value = model.optor;
            parms[8].Value = model.oper_time;

            return parms;
        }

        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareUpdateParameters(Model.member model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_GAME_ID, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_WX_ID, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ALI_ID, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_PROXY_ID, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CS_TYPE, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_FIRST_BALANCE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_BALANCE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPER_TIME, DbType.DateTime, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE, parms);
            }

            parms[0].Value = model.game_id;
            parms[1].Value = model.wx_id;
            parms[2].Value = model.ali_id;
            parms[3].Value = model.proxy_id;
            parms[4].Value = model.cs_type;
            parms[5].Value = model.first_balance;
            parms[6].Value = model.balance;
            parms[7].Value = model.optor;
            parms[8].Value = model.oper_time;
            parms[9].Value = model.id;

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
        internal static void PrepareModel(Model.member model, IDataReader dr)
        {
            model.id = DbValue.GetInt(dr["id"]);
            model.game_id = DbValue.GetString(dr["game_id"]);
            model.wx_id = DbValue.GetString(dr["wx_id"]);
            model.ali_id = DbValue.GetString(dr["ali_id"]);
            model.proxy_id = DbValue.GetString(dr["proxy_id"]);
            model.cs_type = DbValue.GetString(dr["cs_type"]);
            model.first_balance = DbValue.GetDouble(dr["first_balance"]);
            model.balance = DbValue.GetDouble(dr["balance"]);
            model.optor = DbValue.GetString(dr["optor"]);
            model.oper_time = DbValue.GetDateTime(dr["oper_time"]);
        }
    }
}
