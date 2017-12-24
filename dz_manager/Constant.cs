using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_manager
{
    public class Constant
    {
        public const string DB_NOT_CONFIG = "数据库连接未配置";
        public const string DB_CONNECT_FAIL = "数据库连接失败，请检查配置";
        public const string DB_USER_OR_PASSWORD_ERROR = "用户名或密码错误";
        public const string DB_USER_OR_PASSWORD_NULL = "用户名或密码为空";
        public const string WIN_VERIFY_USERINFO = "正在验证用户信息";
        public const string DB_SAVE_ERROR = "数据保存出错";
        public const string WIN_DESK_CREATE = "未开始";
        public const string WIN_DESK_BEGIN = "进行中";
        public const string WIN_DESK_OVER = "已结束";
        public const string WIN_DESK_ALREADY_EXIST = "桌号已经存在";
        public const string WIN_SCORE_DESK_NOT_FOUND = "桌号不存在";
        public const string WIN_SCORE_MEMBER_NOT_FOUND = "会员不存在";
    }
}
