using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CacheClient
{
    using CacheLibrary;

    public partial class frmMain : Form
    {
        CacheLib cache = new CacheLib();

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 寫入快取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetCache_Click(object sender, EventArgs e)
        {
            CacheModel.SetCache query = new CacheModel.SetCache()
            {
                CacheName = txtSetCacheName.Text,
                CacheValue = txtSetCacheValue.Text,
            };

            bool blIsSuccess = cache.SetCache(query);
            txtResult.Text = blIsSuccess.ToString();
        }

        /// <summary>
        /// 取得快取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetCache_Click(object sender, EventArgs e)
        {
            CacheModel.GetCache query = new CacheModel.GetCache()
            {
                CacheName = txtGetCacheName.Text,
            };

            CacheModel.GetCacheResult result = cache.GetCache(query);
            txtResult.Text = JsonConvert.SerializeObject(result);
        }

        /// <summary>
        /// 清除快取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearCache_Click(object sender, EventArgs e)
        {
            CacheModel.ClearCache query = new CacheModel.ClearCache()
            {
                CacheName = txtClearCache.Text,
            };

            bool blIsSuccess = cache.ClearCache(query);
            txtResult.Text = blIsSuccess.ToString();
        }
    }
}
