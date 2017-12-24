using System;

namespace Model
{
    /// <summary>
    /// 实体类 auth_user, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class auth_user : ICloneable
    {
        public auth_user()
        { }

        /// <summary>
        /// 构造函数 auth_user
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        /// <param name="auth_type">0:普通，1：管理员</param>
        public auth_user(int? id, string username, string password, int? auth_type)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.auth_type = auth_type;
        }

        #region 实体属性

        /// <summary>
        /// id
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// username
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 0:普通，1：管理员
        /// </summary>
        public int? auth_type { get; set; }

        #endregion

        #region ICloneable 成员

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

        public override bool Equals(object obj)
        {
            Model.auth_user model = obj as Model.auth_user;
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