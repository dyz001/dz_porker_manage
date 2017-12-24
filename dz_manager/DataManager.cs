using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataInput.DBOper;


namespace dz_manager
{
    public class DataManager
    {
        protected static auth_user user_info;
        public static auth_user GetAuthUser()
        {
            return user_info;
        }
        public static void SetAuthUser(auth_user auth_data)
        {
            user_info = auth_data;
        }

        public static IList<choushui> GetChouShuiList()
        {
            return DBUtil.GetInstance().GetLstItems<choushui>();
        }

        public static IList<fanshui> GetFanShuiList()
        {
            return DBUtil.GetInstance().GetLstItems<fanshui>();
        }
    }
}
