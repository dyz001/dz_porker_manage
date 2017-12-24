using System;

namespace Model
{
    /// <summary>
    /// 实体类 proxy, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class proxy : ICloneable
    {
        public proxy()
        { }

        /// <summary>
        /// 构造函数 proxy
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="no">no</param>
        /// <param name="fs_type">反水方式</param>
        /// <param name="optor">optor</param>
        /// <param name="oper_time">oper_time</param>
        public proxy(int id, string name, string no, string fs_type, string optor, DateTime? oper_time)
        {
            this.id = id;
            this.name = name;
            this.no = no;
            this.fs_type = fs_type;
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
        /// no
        /// </summary>
        public string no { get; set; }

        /// <summary>
        /// 反水方式
        /// </summary>
        public string fs_type { get; set; }

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
            Model.proxy model = obj as Model.proxy;
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