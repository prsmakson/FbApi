using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.IO;
using System.Net;

namespace FbApi.Helpers
{
    static class RequestHelper
    {

        static RequestHelper()
        {

        }

        public static string SendGetRequest(string request)
        {
            WebRequest req = WebRequest.Create(request);
            WebResponse response = req.GetResponse();
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
