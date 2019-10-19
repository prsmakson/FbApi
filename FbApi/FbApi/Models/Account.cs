using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
    sealed public class Account
    {
        private readonly string access_token;
        private readonly string baseUri = "https://graph.facebook.com/v4.0/";
        public Account(string token)
        {
            access_token = token;
        }

        public string getToken()
        {
            return access_token;
        }
        public string GetBaseUri()
        {
            return baseUri;
        }
    }
}
