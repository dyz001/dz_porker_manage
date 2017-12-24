using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DBUtility;

namespace MySqlDAL
{
    /// <summary>
    /// 数据访问类 bill_record ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class bill_record
    {
        internal const string COMMAND_ADD = "INSERT INTO bill_record(desk_name, member_name, take_in, fluctuate, insure, pure_fluctuate, pure_insure, choushui, jingchoushui, other, member_init_balance, transfer, optor, oper_time) VALUES (@in_desk_name, @in_member_name, @in_take_in, @in_fluctuate, @in_insure, @in_pure_fluctuate, @in_pure_insure, @in_choushui, @in_jingchoushui, @in_other, @in_member_init_balance, @in_transfer, @in_optor, @in_oper_time)";
        internal const string COMMAND_UPDATE = "UPDATE bill_record SET desk_name=@in_desk_name, member_name=@in_member_name, take_in=@in_take_in, fluctuate=@in_fluctuate, insure=@in_insure, pure_fluctuate=@in_pure_fluctuate, pure_insure=@in_pure_insure, choushui=@in_choushui, jingchoushui=@in_jingchoushui, other=@in_other, member_init_balance=@in_member_init_balance, transfer=@in_transfer, optor=@in_optor, oper_time=@in_oper_time WHERE id=@in_id";
        internal const string COMMAND_DELETE = "DELETE FROM bill_record WHERE id=@in_id";
        internal const string COMMAND_EXISTS = "SELECT COUNT(1) FROM bill_record WHERE id=@in_id";
        internal const string COMMAND_GETMODEL = "SELECT * FROM bill_record WHERE id=@in_id";
        internal const string COMMAND_GETCOUNT = "SELECT COUNT(*) FROM bill_record";
        internal const string COMMAND_GETLIST = "SELECT * FROM bill_record";

        internal const string PARM_ID = "@in_id";
        internal const string PARM_DESK_NAME = "@in_desk_name";
        internal const string PARM_MEMBER_NAME = "@in_member_name";
        internal const string PARM_TAKE_IN = "@in_take_in";
        internal const string PARM_FLUCTUATE = "@in_fluctuate";
        internal const string PARM_INSURE = "@in_insure";
        internal const string PARM_PURE_FLUCTUATE = "@in_pure_fluctuate";
        internal const string PARM_PURE_INSURE = "@in_pure_insure";
        internal const string PARM_CHOUSHUI = "@in_choushui";
        internal const string PARM_JINGCHOUSHUI = "@in_jingchoushui";
        internal const string PARM_OTHER = "@in_other";
        internal const string PARM_MEMBER_INIT_BALANCE = "@in_member_init_balance";
        internal const string PARM_TRANSFER = "@in_transfer";
        internal const string PARM_OPTOR = "@in_optor";
        internal const string PARM_OPER_TIME = "@in_oper_time";

        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareAddParameters(Model.bill_record model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_ADD);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_DESK_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_MEMBER_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_TAKE_IN, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_FLUCTUATE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_INSURE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_PURE_FLUCTUATE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_PURE_INSURE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CHOUSHUI, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_JINGCHOUSHUI, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OTHER, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_MEMBER_INIT_BALANCE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_TRANSFER, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPER_TIME, DbType.DateTime, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_ADD, parms);
            }

            parms[0].Value = model.desk_name;
            parms[1].Value = model.member_name;
            parms[2].Value = model.take_in;
            parms[3].Value = model.fluctuate;
            parms[4].Value = model.insure;
            parms[5].Value = model.pure_fluctuate;
            parms[6].Value = model.pure_insure;
            parms[7].Value = model.choushui;
            parms[8].Value = model.jingchoushui;
            parms[9].Value = model.other;
            parms[10].Value = model.member_init_balance;
            parms[11].Value = model.transfer;
            parms[12].Value = model.optor;
            parms[13].Value = model.oper_time;

            return parms;
        }

        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static IDbDataParameter[] PrepareUpdateParameters(Model.bill_record model)
        {
            IDbDataParameter[] parms = DbParameterCache.GetCachedParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE);
            if (parms == null)
            {
                parms = new IDbDataParameter[]{
                    dbHelper.CreateDbParameter(PARM_DESK_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_MEMBER_NAME, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_TAKE_IN, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_FLUCTUATE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_INSURE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_PURE_FLUCTUATE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_PURE_INSURE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_CHOUSHUI, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_JINGCHOUSHUI, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OTHER, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_MEMBER_INIT_BALANCE, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_TRANSFER, DbType.Double, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPTOR, DbType.String, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_OPER_TIME, DbType.DateTime, ParameterDirection.Input),
                    dbHelper.CreateDbParameter(PARM_ID, DbType.Int32, ParameterDirection.Input)};
                DbParameterCache.CacheParameterSet(dbHelper.ConnectionString, COMMAND_UPDATE, parms);
            }

            parms[0].Value = model.desk_name;
            parms[1].Value = model.member_name;
            parms[2].Value = model.take_in;
            parms[3].Value = model.fluctuate;
            parms[4].Value = model.insure;
            parms[5].Value = model.pure_fluctuate;
            parms[6].Value = model.pure_insure;
            parms[7].Value = model.choushui;
            parms[8].Value = model.jingchoushui;
            parms[9].Value = model.other;
            parms[10].Value = model.member_init_balance;
            parms[11].Value = model.transfer;
            parms[12].Value = model.optor;
            parms[13].Value = model.oper_time;
            parms[14].Value = model.id;

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
        internal static void PrepareModel(Model.bill_record model, IDataReader dr)
        {
            model.id = DbValue.GetInt(dr["id"]);
            model.desk_name = DbValue.GetString(dr["desk_name"]);
            model.member_name = DbValue.GetString(dr["member_name"]);
            model.take_in = DbValue.GetDouble(dr["take_in"]);
            model.fluctuate = DbValue.GetDouble(dr["fluctuate"]);
            model.insure = DbValue.GetDouble(dr["insure"]);
            model.pure_fluctuate = DbValue.GetDouble(dr["pure_fluctuate"]);
            model.pure_insure = DbValue.GetDouble(dr["pure_insure"]);
            model.choushui = DbValue.GetDouble(dr["choushui"]);
            model.jingchoushui = DbValue.GetDouble(dr["jingchoushui"]);
            model.other = DbValue.GetDouble(dr["other"]);
            model.member_init_balance = DbValue.GetDouble(dr["member_init_balance"]);
            model.transfer = DbValue.GetDouble(dr["transfer"]);
            model.optor = DbValue.GetString(dr["optor"]);
            model.oper_time = DbValue.GetDateTime(dr["oper_time"]);
        }
    }
}
