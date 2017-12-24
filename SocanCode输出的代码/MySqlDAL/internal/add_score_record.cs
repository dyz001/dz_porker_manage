using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DBUtility;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 add_score_record ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class add_score_record
    {
        internal const string COMMAND_ADD = "INSERT INTO add_score_record(desk_id, desk_name, member_id, member_name, cur_score, score, add_time, optor, oper_time) VALUES (@in_desk_id, @in_desk_name, @in_member_id, @in_member_name, @in_cur_score, @in_score, @in_add_time, @in_optor, @in_oper_time)";
        internal const string COMMAND_UPDATE = "UPDATE add_score_record SET desk_id=@in_desk_id, desk_name=@in_desk_name, member_id=@in_member_id, member_name=@in_member_name, cur_score=@in_cur_score, score=@in_score, add_time=@in_add_time, optor=@in_optor, oper_time=@in_oper_time WHERE id=@in_id";
        internal const string COMMAND_DELETE = "DELETE FROM add_score_record WHERE id=@in_id";
        internal const string COMMAND_EXISTS = "SELECT COUNT(1) FROM add_score_record WHERE id=@in_id";
        internal const string COMMAND_GETMODEL = "SELECT * FROM add_score_record WHERE id=@in_id";
        internal const string COMMAND_GETCOUNT = "SELECT COUNT(*) FROM add_score_record";
        internal const string COMMAND_GETLIST = "SELECT * FROM add_score_record";

        internal const string PARM_ID = "@in_id";
        internal const string PARM_DESK_ID = "@in_desk_id";
        internal const string PARM_DESK_NAME = "@in_desk_name";
        internal const string PARM_MEMBER_ID = "@in_member_id";
        internal const string PARM_MEMBER_NAME = "@in_member_name";
        internal const string PARM_CUR_SCORE = "@in_cur_score";
        internal const string PARM_SCORE = "@in_score";
        internal const string PARM_ADD_TIME = "@in_add_time";
        internal const string PARM_OPTOR = "@in_optor";
        internal const string PARM_OPER_TIME = "@in_oper_time";

        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareAddParameters(Model.add_score_record model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_ADD);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_DESK_ID, DbType.Int32, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_DESK_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_MEMBER_ID, DbType.Int32, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_MEMBER_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CUR_SCORE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_SCORE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ADD_TIME, DbType.DateTime, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPER_TIME, DbType.DateTime, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_ADD, parms);
            }

            parms[0].Value = model.desk_id;
            parms[1].Value = model.desk_name;
            parms[2].Value = model.member_id;
            parms[3].Value = model.member_name;
            parms[4].Value = model.cur_score;
            parms[5].Value = model.score;
            parms[6].Value = model.add_time;
            parms[7].Value = model.optor;
            parms[8].Value = model.oper_time;

            return parms;
        }

        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareUpdateParameters(Model.add_score_record model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_DESK_ID, DbType.Int32, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_DESK_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_MEMBER_ID, DbType.Int32, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_MEMBER_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CUR_SCORE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_SCORE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ADD_TIME, DbType.DateTime, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPER_TIME, DbType.DateTime, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE, parms);
            }

            parms[0].Value = model.desk_id;
            parms[1].Value = model.desk_name;
            parms[2].Value = model.member_id;
            parms[3].Value = model.member_name;
            parms[4].Value = model.cur_score;
            parms[5].Value = model.score;
            parms[6].Value = model.add_time;
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
        internal static void PrepareModel(Model.add_score_record model, IDataReader dr)
        {
            model.id = DbValue.GetInt(dr["id"]);
            model.desk_id = DbValue.GetInt(dr["desk_id"]);
            model.desk_name = DbValue.GetString(dr["desk_name"]);
            model.member_id = DbValue.GetInt(dr["member_id"]);
            model.member_name = DbValue.GetString(dr["member_name"]);
            model.cur_score = DbValue.GetDouble(dr["cur_score"]);
            model.score = DbValue.GetDouble(dr["score"]);
            model.add_time = DbValue.GetDateTime(dr["add_time"]);
            model.optor = DbValue.GetString(dr["optor"]);
            model.oper_time = DbValue.GetDateTime(dr["oper_time"]);
        }
    }
}
