using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CacheLibrary;
using System.Runtime.Caching;

namespace CacheServer.Controllers
{
    public class CacheController : ApiController
    {
        ObjectCache cache;

        /// <summary>
        /// 初始化控制器的動作
        /// </summary>
        public CacheController()
        {
            cache = MemoryCache.Default;
        }

        /// <summary>
        /// 取得快取的動作
        /// </summary>
        /// <param name="query">進行快取取得的查詢物件</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("GetCache")]
        [ApiBasicAuthenticationFilter]
        public CacheModel.GetCacheResult GetCache(CacheModel.GetCache query)
        {
            CacheItem item = cache.GetCacheItem(query.CacheName);

            CacheModel.GetCacheResult result = null;
            if (item != null)
            {
                result = new CacheModel.GetCacheResult()
                {
                    CacheName = item.Key,
                    CacheValue = item.Value.ToString(),
                };
            }

            return result;
        }

        /// <summary>
        /// 寫入快取的動作
        /// </summary>
        /// <param name="value">寫入快取的物件</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("SetCache")]
        [ApiBasicAuthenticationFilter]
        public HttpResponseMessage SetCache(CacheModel.SetCache value)
        {
            HttpResponseMessage result = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("OK"),
            };

            try
            {
                CacheItemPolicy policy = new CacheItemPolicy();

                // 指定過期時間，如果都沒有指定，就預設7天
                if (value.AbsoluteExpirationMinute > 0)
                    policy.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(value.AbsoluteExpirationMinute);
                else if (value.SlidingExpirationMinute > 0)
                    policy.SlidingExpiration = TimeSpan.FromMinutes(value.SlidingExpirationMinute);
                else
                    policy.SlidingExpiration = TimeSpan.FromDays(7);

                cache.Set(value.CacheName, value.CacheValue, policy);
            }
            catch (Exception e)
            {
                result.StatusCode = HttpStatusCode.BadRequest;
                result.Content = new StringContent(e.Message);
            }

            return result;
        }

        /// <summary>
        /// 清除快取的動作
        /// </summary>
        /// <param name="value">清除快取的物件</param>
        /// <returns></returns>
        [HttpDelete]
        [ActionName("ClearCache")]
        [ApiBasicAuthenticationFilter]
        public HttpResponseMessage ClearCache(CacheModel.ClearCache value)
        {
            HttpResponseMessage result = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("OK"),
            };

            try
            {
                cache.Remove(value.CacheName);
            }
            catch (Exception e)
            {
                result.StatusCode = HttpStatusCode.BadRequest;
                result.Content = new StringContent(e.Message);
            }

            return result;
        }

        /// <summary>
        /// 取得所有快取的清單
        /// </summary>
        /// <returns></returns>
        [ActionName("ListCache")]
        [ApiBasicAuthenticationFilter]
        [HttpPost]
        public List<CacheModel.GetCacheResult> ListCache()
        {
            List<CacheModel.GetCacheResult> result = new List<CacheModel.GetCacheResult>();

            foreach (var item in cache)
            {
                result.Add(new CacheModel.GetCacheResult()
                {
                    CacheName = item.Key,
                    CacheValue = item.Value.ToString(),
                });
            }

            return result;
        }
    }
}
