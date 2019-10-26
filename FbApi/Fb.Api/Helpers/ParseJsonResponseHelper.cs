﻿using System;
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
		public static IEnumerable<Business> ParseBusiness(string jstring)
		{
			try
			{
				JObject obj = JObject.Parse(jstring);
				var jBusinesss = obj["data"];
				if (!jBusinesss.HasValues)
					return null;
				var result = new List<Business>();
				foreach (var jBusiness in jBusinesss)
				{
					var bu = new Business();
					result.Add(JsonConvert.DeserializeObject<Business>(jBusiness.ToString()));
				}

				return result;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}

		}
		public static IEnumerable<Campaign> ParseCampaigns(string jstring)
		{
			try
			{
				JObject obj = JObject.Parse(jstring);
				var jCampaigns = obj["data"];
				if (!jCampaigns.HasValues)
					return null;
				var result = new List<Campaign>();
				foreach (var jcampaign in jCampaigns)
				{
					var camp = new Campaign();
					result.Add(JsonConvert.DeserializeObject<Campaign>(jcampaign.ToString()));
				}
				return result;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
		}
		public static IEnumerable<AdAccount> ParseAdAccount(string jstring)
		{
			try
			{
				JObject obj = JObject.Parse(jstring);
				var jAdAccounts = obj["owned_ad_accounts"].SelectToken("data");
				if (!jAdAccounts.HasValues)
					return null;
				var result = new List<AdAccount>();
				foreach (var jAdAccount in jAdAccounts)
				{
					var acc = new AdAccount();
					result.Add(JsonConvert.DeserializeObject<AdAccount>(jAdAccount.ToString()));
				}
				return result;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
		}


		public static IEnumerable<Page> ParsePages(string jstring)
		{
			try
			{
				JObject obj = JObject.Parse(jstring);
				var jPages = obj["owned_pages"].SelectToken("data");
				if (!jPages.HasValues)
					return null;
				var result = new List<Page>();
				foreach (var jPage in jPages)
				{
					var page = new Page();
					result.Add(JsonConvert.DeserializeObject<Page>(jPage.ToString()));
				}

				return result;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
		}
		public static IEnumerable<Pixel> ParsePixels(string jstring)
		{
			try
			{
				JObject obj = JObject.Parse(jstring);
				var jPixels = obj["owned_pixels"].SelectToken("data");
				if (!jPixels.HasValues)
					return null;
				var result = new List<Pixel>();
				foreach (var jPixel in jPixels)
				{
					var pixel = new Pixel();
					result.Add(JsonConvert.DeserializeObject<Pixel>(jPixel.ToString()));
				}

				return result;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}

		}
		public static IEnumerable<AdSet> ParseAdsets(string jstring)
		{
			try
			{
				JObject obj = JObject.Parse(jstring);
				var jAdSets = obj["adsets"].SelectToken("data");
				if (!jAdSets.HasValues)
					return null;
				var result = new List<AdSet>();
				foreach (var jAdset in jAdSets)
				{
					var pixel = new AdSet();
					result.Add(JsonConvert.DeserializeObject<AdSet>(jAdset.ToString()));
				}

				return result;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}

		}
		public static string GetEror(string jstring)
		{
			try
			{
				JObject obj = JObject.Parse(jstring);
				var jError = obj["error"];
				if (jError == null)
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
		public static string ParseResultOrId(string jstring)
		{
			try
			{
				JObject obj = JObject.Parse(jstring);
				return (string)obj.SelectToken("id");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
		}


		public static bool ParseResultPostRequest(string jstring)
		{
			try
			{
				JObject obj = JObject.Parse(jstring);
				var success = (string)obj["success"];
				return bool.Parse(success);
			}
			catch (JsonException ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
		#endregion
	}
}
