using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using FbApi.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FbApi.Models.Exstension
{
    static class ClassExtensions
    {

        public static IEnumerable<Business> GetAllBusiness(this Account account)
        {
            string request = account.baseUri + "me/" + "?fields=businesses&access_token=" + account.getToken();
            var jText = RequestHelper.SendGetRequest(request);
            return ParseJsonResponseHelper.ParseBusiness(jText) ?? new List<Business>();
        }
        public static IEnumerable<AdAccount> GetAdAccounts(this Business business, Account account)
        {
            string request = account.baseUri + business.id + "?fields=owned_ad_accounts{name,account_id,account_status}&access_token=" + account.getToken();
            var jText = RequestHelper.SendGetRequest(request);
            return ParseJsonResponseHelper.ParseAdAccount(jText) ?? new List<AdAccount>();
        }
        public static IEnumerable<Page> GetPages(this Business business, Account account)
        {
            string request = account.baseUri + business.id + "?fields=owned_pages{name,id}&access_token=" + account.getToken();
            var jText = RequestHelper.SendGetRequest(request);
            return ParseJsonResponseHelper.ParsePages(jText) ?? new List<Page>();
        }
        public static IEnumerable<Pixel> GetPixels(this Business business, Account account)
        {

            string request = account.baseUri + business.id + "?fields=owned_pixels{name,id}&access_token=" + account.getToken();
            var jText = RequestHelper.SendGetRequest(request);
            return ParseJsonResponseHelper.ParsePixels(jText);
        }
    }
}
