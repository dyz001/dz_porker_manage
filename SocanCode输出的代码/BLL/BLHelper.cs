using System;
using System.Collections;
using System.Configuration;
using System.Web;
using System.Web.Caching;

namespace BLL
{
    /// <summary>
    /// 业务逻辑层基类
    /// </summary>
    public class BLHelper
    {
        private static readonly string CACHEHEADER_MODEL = "Model_";
        private static readonly string CACHEHEADER_LIST = "List_";

        /// <summary>
        /// 是否启用缓存
        /// </summary>
        protected static readonly bool EnableCache = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableCache"]);

        public BLHelper() { }

        /// <summary>
        /// 缓存key的头部
        /// </summary>
        protected string basicKey;

        /// <summary>
        /// 构造函数,请传入basicKey
        /// </summary>
        public BLHelper(string basicKey)
        {
            this.basicKey = basicKey;
        }

        #region 缓存操作

        /// <summary>
        /// 建立一个Model缓存
        /// </summary>
        protected void TryAddModelCache(object modelKey, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            string key = basicKey + CACHEHEADER_MODEL + modelKey.ToString();
            CacheHelper.TryAddCache(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
        }

        /// <summary>
        /// 获取一个Model缓存
        /// </summary>
        protected object GetModelCache(object modelKey)
        {
            return CacheHelper.GetCache(basicKey + CACHEHEADER_MODEL + modelKey.ToString());
        }

        /// <summary>
        /// 删除一个Model缓存
        /// </summary>
        protected void RemoveModelCache(object modelKey)
        {
            CacheHelper.TryRemoveCache(basicKey + CACHEHEADER_MODEL + modelKey.ToString());
        }

        /// <summary>
        /// 删除所有Model缓存
        /// </summary>
        protected void RemoveModelCache()
        {
            CacheHelper.RemoveMultiCache(basicKey + CACHEHEADER_MODEL);
        }

        /// <summary>
        /// 建立一个List缓存
        /// </summary>
        protected void TryAddListCache(object listKey, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            string key = basicKey + CACHEHEADER_LIST + listKey.ToString();
            CacheHelper.TryAddCache(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
        }

        /// <summary>
        /// 获取一个List缓存
        /// </summary>
        protected object GetListCache(object listKey)
        {
            return CacheHelper.GetCache(basicKey + CACHEHEADER_LIST + listKey.ToString());
        }

        /// <summary>
        /// 删除一个List缓存
        /// </summary>
        protected void RemoveListCache(object listKey)
        {
            CacheHelper.TryRemoveCache(basicKey + CACHEHEADER_LIST + listKey.ToString());
        }

        /// <summary>
        /// 删除所有List缓存
        /// </summary>
        protected void RemoveListCache()
        {
            CacheHelper.RemoveMultiCache(basicKey + CACHEHEADER_LIST);
        }

        #endregion
    }
}
