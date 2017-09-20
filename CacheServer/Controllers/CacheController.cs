﻿using System;
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
                cache.Add(value.CacheName, value.CacheValue, new CacheItemPolicy());
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
    }
}
