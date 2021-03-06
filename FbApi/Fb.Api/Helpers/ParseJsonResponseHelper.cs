﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using FbApi.Models;
using System.Linq;
namespace FbApi.Helpers
{
    static class ParseJsonResponseHelper
    {

        public static IEnumerable<Business> ParseBusiness(string jString)
        {
            try
            {
                JObject obj = JObject.Parse(jString);
                var jBusinesss = obj["businesses"].SelectToken("data");
                if (!jBusinesss.HasValues)
                    return null;
                var result = new List<Business>();
                foreach (var jBusiness in jBusinesss)
                    result.Add(new Business { name = (string)jBusiness.SelectToken("name"), id = (string)jBusiness.SelectToken("id") });
                return result;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public static IEnumerable<AdAccount> ParseAdAccount(string jString)
        {
            try
            {
                JObject obj = JObject.Parse(jString);
                var jAdAccounts = obj["owned_ad_accounts"].SelectToken("data");
                if (!jAdAccounts.HasValues)
                    return null;
                var result = new List<AdAccount>();
                foreach (var jAdAccount in jAdAccounts)
                    result.Add(new AdAccount
                    {
                        name = (string)jAdAccount.SelectToken("name"),
                        id = (string)jAdAccount.SelectToken("account_id"),
                        account_status = (ACCOUNT_STATUS)Enum.Parse(typeof(ACCOUNT_STATUS), (string)jAdAccount.SelectToken("account_status"))
                    });
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static IEnumerable<Page> ParsePages(string jString)
        {
            try
            {
                JObject obj = JObject.Parse(jString);
                var jPages = obj["owned_pages"].SelectToken("data");
                if (!jPages.HasValues)
                    return null;
                var result = new List<Page>();
                foreach (var jPage in jPages)
                    result.Add(new Page
                    {
                        id = (string)jPage.SelectToken("id"),
                        name = (string)jPage.SelectToken("name")
                    });

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static IEnumerable<Pixel> ParsePixels(string jString)
        {
            try
            {
                JObject obj = JObject.Parse(jString);
                var jPixels = obj["owned_pixels"].SelectToken("data");
                if (!jPixels.HasValues)
                    return null;
                var result = new List<Pixel>();
                foreach (var jPixel in jPixels)
                    result.Add(new Pixel
                    {
                        id = (string)jPixel.SelectToken("id"),
                        name = (string)jPixel.SelectToken("name")
                    });

                return result;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
