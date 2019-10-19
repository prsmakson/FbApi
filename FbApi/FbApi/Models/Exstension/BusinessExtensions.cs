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
            var jText = RequestHelper.SendGetRequest(request);
            return ParseJsonResponse.ParseBusiness(jText) ?? new List<Business>();
        }
        public static IEnumerable<AdAccount> GetAdAccounts(this Account account, string businessId)
        {
            string request = account.baseUri + businessId + "?fields=owned_ad_accounts{name,account_id,account_status}&access_token=" + account.access_token;
            var jText = RequestHelper.SendGetRequest(request);
            return ParseJsonResponse.ParseAdAccount(jText) ?? new List<AdAccount>();
        }

    }
}
