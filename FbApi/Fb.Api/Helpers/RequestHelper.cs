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

        public static string SendGetRequest(string request,string userAgent=null)
        {

            HttpWebRequest req =(HttpWebRequest)WebRequest.Create(request);
            req.Method = "GET";
            req.UserAgent = userAgent;
            var response = (HttpWebResponse)req.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);
        }
        public static void SendPostRequest(string Request)
        {

        }

    }
}
