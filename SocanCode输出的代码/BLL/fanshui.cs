using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;

namespace BLL
{
    /// <summary>
    /// 业务逻辑类 fanshui
    /// </summary>
    public class fanshui: BLHelper
    {
        private readonly MySqlDAL.fanshui dal = new MySqlDAL.fanshui();

        public fanshui()
            : base("_fanshui_") { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.fanshui model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.fanshui model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.id);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? id)
        {
            int count = dal.Delete(id);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(id.ToString());
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? id)
        {
            bool bln = dal.Exists(id);
            return bln;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.fanshui GetModel(int? id)
        {
            Model.fanshui model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(id);
            }
            else
            {
                string key = id.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.fanshui)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(id);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.fanshui> GetList()
        {
            List<Model.fanshui> lst = dal.GetList();
            return lst;
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.fanshui> GetPageList(PageInfo pi)
        {
            PageList<Model.fanshui> pl = dal.GetPageList(pi);
            return pl;
        }
    }
}
