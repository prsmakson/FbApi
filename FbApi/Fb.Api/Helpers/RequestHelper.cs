using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Net.Http.Headers;

namespace Fb.Api.Helpers
{
    static class RequestHelper
    {

        static RequestHelper()
        {

        }

        public static string SendGetRequest(string request, string userAgent = null)
        {
            return SendRequest(request, userAgent, "GET");
        }
        public static string SendPostRequest(string Request, string userAgent)
        {
            return SendRequest(Request, userAgent, "POST");
        }
        private static string SendRequest(string Request, string userAgent, string method)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Request);
            req.Method = method;
            req.UserAgent = userAgent;
            var response = (HttpWebResponse)req.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

    }
}
