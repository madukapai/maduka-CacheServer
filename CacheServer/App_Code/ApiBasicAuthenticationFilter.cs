using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CacheServer
{
    using System.Web.Http.Controllers;

    public class ApiBasicAuthenticationFilter : BasicAuthenticationFilter
    {

        public ApiBasicAuthenticationFilter()
        { }

        public ApiBasicAuthenticationFilter(bool active) : base(active)
        { }


        protected override bool OnAuthorizeUser(string username, string password, HttpActionContext actionContext)
        {
            // 在這裡加上帳號密碼的驗證，可以從資料庫取出資料進行比對
            string strUserName = ConfigurationManager.AppSettings["AuthenticationUsername"].ToString();
            string strPassword = ConfigurationManager.AppSettings["AuthenticationPassword"].ToString();
            bool blIsAuthorize = false;

            if (strUserName == username && strPassword == password)
                blIsAuthorize = true;

            return blIsAuthorize;
        }
    }
}