using System;

namespace Model
{
    /// <summary>
    /// 实体类 member, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class member : ICloneable
    {
        public member()
        { }

        /// <summary>
        /// 构造函数 member
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="game_id">game_id</param>
        /// <param name="wx_id">wx_id</param>
        /// <param name="ali_id">ali_id</param>
        /// <param name="proxy_id">proxy_id</param>
        /// <param name="cs_type">抽水方式</param>
        /// <param name="first_balance">first_balance</param>
        /// <param name="balance">额度</param>
        /// <param name="optor">操作人</param>
        /// <param name="oper_time">oper_time</param>
        public member(int id, string game_id, string wx_id, string ali_id, string proxy_id, string cs_type, double first_balance, double balance, string optor, DateTime? oper_time)
        {
            this.id = id;
            this.game_id = game_id;
            this.wx_id = wx_id;
            this.ali_id = ali_id;
            this.proxy_id = proxy_id;
            this.cs_type = cs_type;
            this.first_balance = first_balance;
            this.balance = balance;
            this.optor = optor;
            this.oper_time = oper_time;
        }

        #region 实体属性

        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// game_id
        /// </summary>
        public string game_id { get; set; }

        /// <summary>
        /// wx_id
        /// </summary>
        public string wx_id { get; set; }

        /// <summary>
        /// ali_id
        /// </summary>
        public string ali_id { get; set; }

        /// <summary>
        /// proxy_id
        /// </summary>
        public string proxy_id { get; set; }

        /// <summary>
        /// 抽水方式
        /// </summary>
        public string cs_type { get; set; }

        /// <summary>
        /// first_balance
        /// </summary>
        public double first_balance { get; set; }

        /// <summary>
        /// 额度
        /// </summary>
        public double balance { get; set; }

        /// <summary>
        /// 操作人
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
            Model.member model = obj as Model.member;
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