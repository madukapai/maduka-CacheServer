using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CacheLibrary
{
    public class CacheModel
    {
        public class GetCache
        {
            public string CacheName { get; set; }
        }

        public class GetCacheResult
        {
            public string CacheName { get; set; }
            public string CacheValue { get; set; }
        }

        public class SetCache
        {
            public string CacheName { get; set; }
            public string CacheValue { get; set; }
        }

        public class ClearCache
        {
            public string CacheName { get; set; }
        }
    }
}