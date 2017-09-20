using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Newtonsoft.Json;
using System.Net;

namespace CacheLibrary
{
    public class CacheLib
    {
        string strUrl = "http://" + ConfigurationManager.AppSettings["CacheServerUrl"].ToString() + "/api/Cache";
        HttpStatusCode code = HttpStatusCode.OK;

        /// <summary>
        /// 取得快取的動作
        /// </summary>
        /// <param name="query">進行快取取得的查詢物件</param>
        /// <returns></returns>
        public CacheModel.GetCacheResult GetCache(CacheModel.GetCache query)
        {
            return JsonConvert.DeserializeObject<CacheModel.GetCacheResult>
                (new Utility().CallAPI(strUrl + "/GetCache", "POST", JsonConvert.SerializeObject(query), out code));
        }

        /// <summary>
        /// 寫入快取的動作
        /// </summary>
        /// <param name="value">寫入快取的物件</param>
        /// <returns></returns>
        public bool SetCache(CacheModel.SetCache value)
        {
            string strResult = new Utility().CallAPI(strUrl + "/SetCache", "POST", JsonConvert.SerializeObject(value), out code);
            return (code == HttpStatusCode.OK) ? true : false;
        }

        /// <summary>
        /// 清除快取的動作
        /// </summary>
        /// <param name="value">清除快取的物件</param>
        /// <returns></returns>
        public bool ClearCache(CacheModel.ClearCache value)
        {
            string strResult = new Utility().CallAPI(strUrl + "/ClearCache", "DELETE", JsonConvert.SerializeObject(value), out code);
            return (code == HttpStatusCode.OK) ? true : false;
        }
    }
}
