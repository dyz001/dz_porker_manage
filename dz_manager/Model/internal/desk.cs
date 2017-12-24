using System;

namespace Model
{
    /// <summary>
    /// 实体类 desk, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class desk : ICloneable
    {
        public desk()
        { }

        /// <summary>
        /// 构造函数 desk
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="income">营收</param>
        /// <param name="league">联盟</param>
        /// <param name="create_date">create_date</param>
        /// <param name="status">0:创建，1:进行中, 2: 已结束</param>
        /// <param name="optor">操作人</param>
        /// <param name="oper_time">操作时间</param>
        public desk(int id, string name, double income, double league, DateTime? create_date, int status, string optor, DateTime? oper_time)
        {
            this.id = id;
            this.name = name;
            this.income = income;
            this.league = league;
            this.create_date = create_date;
            this.status = status;
            this.optor = optor;
            this.oper_time = oper_time;
        }

        #region 实体属性

        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 营收
        /// </summary>
        public double income { get; set; }

        /// <summary>
        /// 联盟
        /// </summary>
        public double league { get; set; }

        /// <summary>
        /// create_date
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 0:创建，1:进行中, 2: 已结束
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public string optor { get; set; }

        /// <summary>
        /// 操作时间
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
            Model.desk model = obj as Model.desk;
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