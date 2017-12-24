using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DBUtility;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 add_balance_record ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class add_balance_record
    {
        internal const string COMMAND_ADD = "INSERT INTO add_balance_record(game_id, add_balance, cur_balance, optor, opter_time) VALUES (@in_game_id, @in_add_balance, @in_cur_balance, @in_optor, @in_opter_time)";
        internal const string COMMAND_UPDATE = "UPDATE add_balance_record SET game_id=@in_game_id, add_balance=@in_add_balance, cur_balance=@in_cur_balance, optor=@in_optor, opter_time=@in_opter_time WHERE id=@in_id";
        internal const string COMMAND_DELETE = "DELETE FROM add_balance_record WHERE id=@in_id";
        internal const string COMMAND_EXISTS = "SELECT COUNT(1) FROM add_balance_record WHERE id=@in_id";
        internal const string COMMAND_GETMODEL = "SELECT * FROM add_balance_record WHERE id=@in_id";
        internal const string COMMAND_GETCOUNT = "SELECT COUNT(*) FROM add_balance_record";
        internal const string COMMAND_GETLIST = "SELECT * FROM add_balance_record";

        internal const string PARM_ID = "@in_id";
        internal const string PARM_GAME_ID = "@in_game_id";
        internal const string PARM_ADD_BALANCE = "@in_add_balance";
        internal const string PARM_CUR_BALANCE = "@in_cur_balance";
        internal const string PARM_OPTOR = "@in_optor";
        internal const string PARM_OPTER_TIME = "@in_opter_time";

        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareAddParameters(Model.add_balance_record model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_ADD);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_GAME_ID, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ADD_BALANCE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CUR_BALANCE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTER_TIME, DbType.DateTime, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_ADD, parms);
            }

            parms[0].Value = model.game_id;
            parms[1].Value = model.add_balance;
            parms[2].Value = model.cur_balance;
            parms[3].Value = model.optor;
            parms[4].Value = model.opter_time;

            return parms;
        }

        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareUpdateParameters(Model.add_balance_record model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_GAME_ID, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ADD_BALANCE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CUR_BALANCE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTER_TIME, DbType.DateTime, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE, parms);
            }

            parms[0].Value = model.game_id;
            parms[1].Value = model.add_balance;
            parms[2].Value = model.cur_balance;
            parms[3].Value = model.optor;
            parms[4].Value = model.opter_time;
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
        internal static void PrepareModel(Model.add_balance_record model, IDataReader dr)
        {
            model.id = DbValue.GetInt(dr["id"]);
            model.game_id = DbValue.GetString(dr["game_id"]);
            model.add_balance = DbValue.GetDouble(dr["add_balance"]);
            model.cur_balance = DbValue.GetDouble(dr["cur_balance"]);
            model.optor = DbValue.GetString(dr["optor"]);
            model.opter_time = DbValue.GetDateTime(dr["opter_time"]);
        }
    }
}
