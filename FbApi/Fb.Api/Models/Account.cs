using System;
using System.Collections.Generic;
using System.Text;
using Fb.Api.Helpers;
namespace Fb.Api.Models
{
    public class Account
    {
        private readonly string access_token;
        public readonly string baseUri = "https://graph.facebook.com/v4.0/";
        public HttpWEbRequestSettings postSettings { get; private set; }
        public HttpWEbRequestSettings getSettings { get; private set; }
        public Account(string token)
        {
            access_token = token;
            SetDefaultSettingsRequests();
        }

        public string getToken()
        {
            return access_token;
        }

        public void SetPostRequestSettings(HttpWEbRequestSettings settings)
        {

        }
        public void SetGetRequestSettings(HttpWEbRequestSettings settings)
        {

        }
        private void SetDefaultSettingsRequests()
        {
            postSettings = new HttpWEbRequestSettings { requestMethod = "POST" };
            getSettings = new HttpWEbRequestSettings { requestMethod = "GET" };
        }
        
    }
}
