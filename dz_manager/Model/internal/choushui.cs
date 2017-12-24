using System;

namespace Model
{
    /// <summary>
    /// 实体类 choushui, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class choushui : ICloneable
    {
        public choushui()
        { }

        /// <summary>
        /// 构造函数 choushui
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="cs_type">cs_type</param>
        /// <param name="cs_value">cs_value</param>
        public choushui(int id, string cs_type, double cs_value)
        {
            this.id = id;
            this.cs_type = cs_type;
            this.cs_value = cs_value;
        }

        #region 实体属性

        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// cs_type
        /// </summary>
        public string cs_type { get; set; }

        /// <summary>
        /// cs_value
        /// </summary>
        public double cs_value { get; set; }

        #endregion

        #region ICloneable 成员

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

        public override bool Equals(object obj)
        {
            Model.choushui model = obj as Model.choushui;
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