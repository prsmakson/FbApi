using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Fb.Api.Models;
using System.Linq;
using Fb.Api.Models.Exstension;
namespace Fb.Api.Helpers
{
    static class ParseJsonResponseHelper
    {

        #region GetObjects
        public static IEnumerable<Business> ParseBusiness(string jString)
        {
            try
            {
                JObject obj = JObject.Parse(jString);
                var jBusinesss = obj["data"];
                if (!jBusinesss.HasValues)
                    return null;
                var result = new List<Business>();
                foreach (var jBusiness in jBusinesss)
                {
                    var bu = new Business();
                    result.Add(bu.GetValuesFromJson(jBusiness));
                }
                 
                return result;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public static IEnumerable<Campaign> ParseCampaigns(string jString)
        {
            try
            {
                JObject obj = JObject.Parse(jString);
                var jCampaigns = obj["data"];
                if (!jCampaigns.HasValues)
                    return null;
                var result = new List<Campaign>();
                foreach (var jcampaign in jCampaigns)
                {
                    var camp = new Campaign();
                    result.Add(camp.GetValuesFromJson(jcampaign));
                }
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
                {
                    var acc = new AdAccount();
                    result.Add(acc.GetValuesFromJson(jAdAccount));
                }
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
                {
                    var page = new Page();
                    result.Add(page.GetValuesFromJson(jPage));
                }

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
                {
                    var pixel =  new Pixel();
                    result.Add(pixel.GetValuesFromJson(jPixel));
                }

                return result;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public static string GetEror(string jString)
        {
            try
            {
                JObject obj = JObject.Parse(jString);
                var jError = obj["error"];
                if (jError==null)
                    return null;
               

                return jError.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion
        #region SetObjects
        public static string ParseResultOrId(string jString)
        {
            try
            {
                JObject obj = JObject.Parse(jString);
                return (string) obj.SelectToken("id");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Error";
            }
        }
       
        
        public static bool ParseResultPostRequest(string jString)
        {
            try
            {
                JObject obj = JObject.Parse(jString);
                var success = (string)obj["success"];
                return bool.Parse(success);
            }
            catch(JsonException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        #endregion
    }
}
