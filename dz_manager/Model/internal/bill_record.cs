using System;

namespace Model
{
    /// <summary>
    /// 实体类 bill_record, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class bill_record : ICloneable
    {
        public bill_record()
        { }

        /// <summary>
        /// 构造函数 bill_record
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="desk_name">desk_name</param>
        /// <param name="member_name">member_name</param>
        /// <param name="take_in">take_in</param>
        /// <param name="fluctuate">fluctuate</param>
        /// <param name="insure">insure</param>
        /// <param name="pure_fluctuate">pure_fluctuate</param>
        /// <param name="pure_insure">pure_insure</param>
        /// <param name="choushui">choushui</param>
        /// <param name="jingchoushui">jingchoushui</param>
        /// <param name="other">other</param>
        /// <param name="member_init_balance">member_init_balance</param>
        /// <param name="transfer">transfer</param>
        /// <param name="optor">optor</param>
        /// <param name="oper_time">oper_time</param>
        public bill_record(int id, string desk_name, string member_name, double take_in, double fluctuate, double insure, double pure_fluctuate, double pure_insure, double choushui, double jingchoushui, double other, double member_init_balance, double transfer, string optor, DateTime? oper_time)
        {
            this.id = id;
            this.desk_name = desk_name;
            this.member_name = member_name;
            this.take_in = take_in;
            this.fluctuate = fluctuate;
            this.insure = insure;
            this.pure_fluctuate = pure_fluctuate;
            this.pure_insure = pure_insure;
            this.choushui = choushui;
            this.jingchoushui = jingchoushui;
            this.other = other;
            this.member_init_balance = member_init_balance;
            this.transfer = transfer;
            this.optor = optor;
            this.oper_time = oper_time;
        }

        #region 实体属性

        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// desk_name
        /// </summary>
        public string desk_name { get; set; }

        /// <summary>
        /// member_name
        /// </summary>
        public string member_name { get; set; }

        /// <summary>
        /// take_in
        /// </summary>
        public double take_in { get; set; }

        /// <summary>
        /// fluctuate
        /// </summary>
        public double fluctuate { get; set; }

        /// <summary>
        /// insure
        /// </summary>
        public double insure { get; set; }

        /// <summary>
        /// pure_fluctuate
        /// </summary>
        public double pure_fluctuate { get; set; }

        /// <summary>
        /// pure_insure
        /// </summary>
        public double pure_insure { get; set; }

        /// <summary>
        /// choushui
        /// </summary>
        public double choushui { get; set; }

        /// <summary>
        /// jingchoushui
        /// </summary>
        public double jingchoushui { get; set; }

        /// <summary>
        /// other
        /// </summary>
        public double other { get; set; }

        /// <summary>
        /// member_init_balance
        /// </summary>
        public double member_init_balance { get; set; }

        /// <summary>
        /// transfer
        /// </summary>
        public double transfer { get; set; }

        /// <summary>
        /// optor
        /// </summary>
        public string optor { get; set; }

        /// <summary>
        /// oper_time
        /// </summary>
        public DateTime? oper_time { get; set; }

        #endregion

        #region ICloneable 成员

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

        public override bool Equals(object obj)
        {
            Model.bill_record model = obj as Model.bill_record;
            if (model != null && model.id == this.id)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}