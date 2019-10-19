using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using FbApi.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FbApi.Models.Exstension
{
    static class BusinessExtensions
    {

        public static IEnumerable<Business> GetAllBusiness(this Account account)
        {
            string request = account.baseUri + "me/" + "?fields=businesses&access_token=" + account.access_token;
            var text= RequestHelper.SendGetRequest(request);
            return ParseJsonResponse.ParseBusiness(text) ?? new List<Business>();
        }

        
    }
}
