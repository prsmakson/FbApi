﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Fb.Api.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Fb.Api.Models.Exstension
{
    public static class GetClassExtensions
    {

        public static IEnumerable<Business> GetAllBusiness(this Account account)
        {
            string request = account.baseUri + "me/" + "?fields=businesses&access_token=" + account.getToken();
            return ParseJsonResponseHelper.ParseBusiness(SendRequest(request, account.getSettings)) ?? new List<Business>();
        }
        public static IEnumerable<AdAccount> GetAdAccounts(this Business business, Account account)
        {
            string request = account.baseUri + business.id + "?fields=owned_ad_accounts{name,account_id,account_status}&access_token=" + account.getToken();
            return ParseJsonResponseHelper.ParseAdAccount(SendRequest(request, account.getSettings)) ?? new List<AdAccount>();
        }
        public static IEnumerable<Page> GetPages(this Business business, Account account)
        {
            string request = account.baseUri + business.id + "?fields=owned_pages{name,id,access_token}&access_token=" + account.getToken();
            return ParseJsonResponseHelper.ParsePages(SendRequest(request, account.getSettings)) ?? new List<Page>();
        }
        public static IEnumerable<Pixel> GetPixels(this Business business, Account account)
        {

            string request = account.baseUri + business.id + "?fields=owned_pixels{name,id}&access_token=" + account.getToken();
            return ParseJsonResponseHelper.ParsePixels(SendRequest(request,account.getSettings)) ?? new List<Pixel>();
        }
        private static string SendRequest(string request,HttpWEbRequestSettings settings)
        {
            var jText = RequestHelper.SendRequest(request,settings);
            var err = ParseJsonResponseHelper.GetEror(jText);
            if (err != null)
                throw new Exception(err);
            else return jText;
        }
    }
}
