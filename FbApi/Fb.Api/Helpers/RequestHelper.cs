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
        public static string SendRequest(string request, HttpWEbRequestSettings settings)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(request);
            req.Method = settings.requestMethod;
            foreach (var header in settings.headers)
                req.Headers.Add(header.Key, header.Value);
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
    public class HttpWEbRequestSettings
    {
        public string requestMethod { get; set; }
        public Dictionary<HttpRequestHeader, string> headers { get; set; } = new Dictionary<HttpRequestHeader, string>();

    }
}
