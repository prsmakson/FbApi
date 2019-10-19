using System;
using System.Collections.Generic;
using System.Text;

namespace FbApi.Models
{
    class Account
    {
        public readonly string access_token;
        public readonly string baseUri = "https://graph.facebook.com/v4.0/";
        public Account(string token)
        {
            access_token = token;
        }
    }
}
