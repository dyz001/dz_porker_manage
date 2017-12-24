using System;

namespace Model
{
    /// <summary>
    /// 实体类 fanshui, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class fanshui : ICloneable
    {
        public fanshui()
        { }

        /// <summary>
        /// 构造函数 fanshui
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="fs_type">fs_type</param>
        /// <param name="fs_value">fs_value</param>
        public fanshui(int? id, string fs_type, double? fs_value)
        {
            this.id = id;
            this.fs_type = fs_type;
            this.fs_value = fs_value;
        }

        #region 实体属性

        /// <summary>
        /// id
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// fs_type
        /// </summary>
        public string fs_type { get; set; }

        /// <summary>
        /// fs_value
        /// </summary>
        public double? fs_value { get; set; }

        #endregion

        #region ICloneable 成员

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

        public override bool Equals(object obj)
        {
            Model.fanshui model = obj as Model.fanshui;
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