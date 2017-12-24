using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DBUtility;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 desk ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class desk
    {
        internal const string COMMAND_ADD = "INSERT INTO desk(name, income, league, create_date, status, optor, oper_time) VALUES (@in_name, @in_income, @in_league, @in_create_date, @in_status, @in_optor, @in_oper_time)";
        internal const string COMMAND_UPDATE = "UPDATE desk SET name=@in_name, income=@in_income, league=@in_league, create_date=@in_create_date, status=@in_status, optor=@in_optor, oper_time=@in_oper_time WHERE id=@in_id";
        internal const string COMMAND_DELETE = "DELETE FROM desk WHERE id=@in_id";
        internal const string COMMAND_EXISTS = "SELECT COUNT(1) FROM desk WHERE id=@in_id";
        internal const string COMMAND_GETMODEL = "SELECT * FROM desk WHERE id=@in_id";
        internal const string COMMAND_GETCOUNT = "SELECT COUNT(*) FROM desk";
        internal const string COMMAND_GETLIST = "SELECT * FROM desk";

        internal const string PARM_ID = "@in_id";
        internal const string PARM_NAME = "@in_name";
        internal const string PARM_INCOME = "@in_income";
        internal const string PARM_LEAGUE = "@in_league";
        internal const string PARM_CREATE_DATE = "@in_create_date";
        internal const string PARM_STATUS = "@in_status";
        internal const string PARM_OPTOR = "@in_optor";
        internal const string PARM_OPER_TIME = "@in_oper_time";

        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareAddParameters(Model.desk model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_ADD);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_INCOME, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_LEAGUE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CREATE_DATE, DbType.DateTime, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_STATUS, DbType.Int32, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPER_TIME, DbType.DateTime, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_ADD, parms);
            }

            parms[0].Value = model.name;
            parms[1].Value = model.income;
            parms[2].Value = model.league;
            parms[3].Value = model.create_date;
            parms[4].Value = model.status;
            parms[5].Value = model.optor;
            parms[6].Value = model.oper_time;

            return parms;
        }

        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareUpdateParameters(Model.desk model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_INCOME, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_LEAGUE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CREATE_DATE, DbType.DateTime, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_STATUS, DbType.Int32, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPER_TIME, DbType.DateTime, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE, parms);
            }

            parms[0].Value = model.name;
            parms[1].Value = model.income;
            parms[2].Value = model.league;
            parms[3].Value = model.create_date;
            parms[4].Value = model.status;
            parms[5].Value = model.optor;
            parms[6].Value = model.oper_time;
            parms[7].Value = model.id;

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
        internal static void PrepareModel(Model.desk model, IDataReader dr)
        {
            model.id = DbValue.GetInt(dr["id"]);
            model.name = DbValue.GetString(dr["name"]);
            model.income = DbValue.GetDouble(dr["income"]);
            model.league = DbValue.GetDouble(dr["league"]);
            model.create_date = DbValue.GetDateTime(dr["create_date"]);
            model.status = DbValue.GetInt(dr["status"]);
            model.optor = DbValue.GetString(dr["optor"]);
            model.oper_time = DbValue.GetDateTime(dr["oper_time"]);
        }
    }
}
