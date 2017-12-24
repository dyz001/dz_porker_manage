using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;

namespace BLL
{
    /// <summary>
    /// 业务逻辑类 bill_record
    /// </summary>
    public class bill_record: BLHelper
    {
        private readonly MySqlDAL.bill_record dal = new MySqlDAL.bill_record();

        public bill_record()
            : base("_bill_record_") { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.bill_record model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.bill_record model)
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
        public Model.bill_record GetModel(int? id)
        {
            Model.bill_record model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(id);
            }
            else
            {
                string key = id.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.bill_record)GetModelCache(key);
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
        public List<Model.bill_record> GetList()
        {
            List<Model.bill_record> lst = dal.GetList();
            return lst;
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.bill_record> GetPageList(PageInfo pi)
        {
            PageList<Model.bill_record> pl = dal.GetPageList(pi);
            return pl;
        }
    }
}
