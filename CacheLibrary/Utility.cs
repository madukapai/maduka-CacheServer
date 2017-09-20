using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CacheLibrary
{
    internal class Utility
    {
        string strUsername = ConfigurationManager.AppSettings["CacheServerUsername"].ToString();
        string strPassword = ConfigurationManager.AppSettings["CacheServerPassword"].ToString();
        string strAuthorization = "";

        public Utility()
        {
            string strAuthorizationContent = strUsername + ":" + strPassword;
            var plainTextBytes = Encoding.UTF8.GetBytes(strAuthorizationContent);
            strAuthorization = Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// 呼叫API的動作
        /// </summary>
        /// <param name="strUrl"></param>
        /// <param name="strHttpMethod"></param>
        /// <param name="strPostContent"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        internal string CallAPI(string strUrl, string strHttpMethod, string strPostContent, out HttpStatusCode code)
        {
            HttpWebRequest request = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            request.Method = strHttpMethod;
            code = HttpStatusCode.OK;
            request.KeepAlive = true;
            request.Headers.Add("Authorization", "Basic " + strAuthorization);

            if (strPostContent != "" && strPostContent != string.Empty)
            {
                request.ContentType = "application/json";
                byte[] bs = Encoding.UTF8.GetBytes(strPostContent);
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(bs, 0, bs.Length);
            }
            else
            {
                request.ContentLength = 0;
            }

            string strReturn = "";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var respStream = response.GetResponseStream();
                strReturn = new StreamReader(respStream).ReadToEnd();
            }
            catch (Exception e)
            {
                strReturn = e.Message;
                code = HttpStatusCode.NotFound;
            }

            return strReturn;
        }
    }
}
