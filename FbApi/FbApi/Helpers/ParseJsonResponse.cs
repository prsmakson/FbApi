using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using FbApi.Models;
namespace FbApi.Helpers
{
    static class ParseJsonResponse
    {

        public static IEnumerable<Business> ParseBusiness(string jString)
        {
            try
            {
                JObject obj = JObject.Parse(jString);
                var jBusinesss = obj["businesses"].SelectToken("data");
                if (!jBusinesss.HasValues)
                    return null;
                List<Business> result = new List<Business>();
                foreach (var b in jBusinesss)
                    result.Add(new Business { name = (string)b.SelectToken("name"), id = (string)b.SelectToken("id") });
                return result;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }
    }
}
