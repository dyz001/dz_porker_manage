using System;

namespace Model
{
    /// <summary>
    /// 实体类 add_balance_record, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class add_balance_record : ICloneable
    {
        public add_balance_record()
        { }

        /// <summary>
        /// 构造函数 add_balance_record
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="game_id">game_id</param>
        /// <param name="add_balance">add_balance</param>
        /// <param name="cur_balance">cur_balance</param>
        /// <param name="optor">optor</param>
        /// <param name="opter_time">opter_time</param>
        public add_balance_record(int? id, string game_id, double? add_balance, double? cur_balance, string optor, DateTime? opter_time)
        {
            this.id = id;
            this.game_id = game_id;
            this.add_balance = add_balance;
            this.cur_balance = cur_balance;
            this.optor = optor;
            this.opter_time = opter_time;
        }

        #region 实体属性

        /// <summary>
        /// id
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// game_id
        /// </summary>
        public string game_id { get; set; }

        /// <summary>
        /// add_balance
        /// </summary>
        public double? add_balance { get; set; }

        /// <summary>
        /// cur_balance
        /// </summary>
        public double? cur_balance { get; set; }

        /// <summary>
        /// optor
        /// </summary>
        public string optor { get; set; }

        /// <summary>
        /// opter_time
        /// </summary>
        public DateTime? opter_time { get; set; }

        #endregion

        #region ICloneable 成员

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

        public override bool Equals(object obj)
        {
            Model.add_balance_record model = obj as Model.add_balance_record;
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