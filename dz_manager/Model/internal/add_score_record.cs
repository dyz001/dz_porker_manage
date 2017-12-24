using System;

namespace Model
{
    /// <summary>
    /// 实体类 add_score_record, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class add_score_record : ICloneable
    {
        public add_score_record()
        { }

        /// <summary>
        /// 构造函数 add_score_record
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="desk_id">desk_id</param>
        /// <param name="desk_name">desk_name</param>
        /// <param name="member_id">member_id</param>
        /// <param name="member_name">member_name</param>
        /// <param name="cur_score">cur_score</param>
        /// <param name="score">score</param>
        /// <param name="add_time">add_time</param>
        /// <param name="optor">optor</param>
        /// <param name="oper_time">oper_time</param>
        public add_score_record(int id, int desk_id, string desk_name, int member_id, string member_name, double cur_score, double score, DateTime add_time, string optor, DateTime? oper_time)
        {
            this.id = id;
            this.desk_id = desk_id;
            this.desk_name = desk_name;
            this.member_id = member_id;
            this.member_name = member_name;
            this.cur_score = cur_score;
            this.score = score;
            this.add_time = add_time;
            this.optor = optor;
            this.oper_time = oper_time;
        }

        #region 实体属性

        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// desk_id
        /// </summary>
        public int desk_id { get; set; }

        /// <summary>
        /// desk_name
        /// </summary>
        public string desk_name { get; set; }

        /// <summary>
        /// member_id
        /// </summary>
        public int member_id { get; set; }

        /// <summary>
        /// member_name
        /// </summary>
        public string member_name { get; set; }

        /// <summary>
        /// cur_score
        /// </summary>
        public double cur_score { get; set; }

        /// <summary>
        /// score
        /// </summary>
        public double score { get; set; }

        /// <summary>
        /// add_time
        /// </summary>
        public DateTime add_time { get; set; }

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
            Model.add_score_record model = obj as Model.add_score_record;
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