using System;
using System.Net.Http;
using Fb.Api;
using Fb.Api.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Diagnostics;
namespace Fb.Marketing
{
	class Program
	{
		static void Main(string[] args)
		{
			string token = "EAABsbCS1iHgBAN0HE7drDDxriG5bCk9eQohQDZCEQe8ze31CHopJWaDLCR17PYxmqVXtZABiuDIvmlUnOWNzT1w91mUEyenWaU7FEldulda5JHIgRQBl5lXRlYgSYIYfPakSoQXx4ivZCpZAqktwZCBzpiwFlVoCmn64X0d1GJwZDZD";
			//string token = "EAABsbCS1iHgBAIfMBMUxWbC1PNHnlrWzXiIqTTemzhLqy0ZB4QZCmdoKBDhbZAyRs5Ft7jcvl6CuEAluGDNpbLivvJ6pS2rh2GJYMJoaUDpQ5ZCUJVoJMWVInTXg4JRusCh7JSXnfJs9JjmLZAOc7IywCp03sDaTuWEtBgpbk2Weg83jnj8inuXCeprJRdxIZD";
			try
			{
				Stopwatch time = new Stopwatch();
				time.Start();
				Account R = new Account(token);

				var business = R.GetAllBusiness().ToList();
				var b = business.First(r => r.name == "OlgaBus21");
				//b.LoadReferencesObject();
				b.GetAdAccounts();
				//b.GetPages();
				//b.GetPixels();
				time.Stop();
				foreach (var r in business)
				{

					var prop = typeof(Business).GetProperties().Where(r => r.PropertyType == typeof(string) || r.PropertyType == typeof(bool));
					foreach (var p in prop)
						Console.WriteLine($"Name:{p.Name}, value: {p.GetValue(r)}");
					Console.WriteLine();

				}
				var AdAccounts = b.GetAdAccounts();

				foreach (var rs in AdAccounts)
				{
					rs.GetCampaigns();
					var prop = typeof(AdAccount).GetProperties().Where(r => r.PropertyType == typeof(string) || r.PropertyType == typeof(bool));
					foreach (var p in prop)
						Console.WriteLine($"Name:{p.Name}, value: {p.GetValue(rs)}");
					Console.WriteLine();
				}
				foreach (var c in AdAccounts.First(r => r.name == "4").campaigns)
				{
					var prop = typeof(Campaign).GetProperties().Where(r => r.PropertyType == typeof(string) || r.PropertyType == typeof(bool));
					foreach (var p in prop)
						Console.WriteLine($"Name:{p.Name}, value: {p.GetValue(c)}");
					Console.WriteLine();
				}
				foreach (var q in AdAccounts.First(r => r.name == "4").campaigns.First().GetAdSets())
				{
					var prop = typeof(AdSet).GetProperties().Where(r => r.PropertyType == typeof(string) || r.PropertyType == typeof(bool));
					foreach (var p in prop)
						Console.WriteLine($"Name:{p.Name}, value: {p.GetValue(q)}");
					Console.WriteLine();
				}
				//foreach (var rs in b.pages)
				//{

				//	Console.WriteLine($"Name:{rs.name},id:{rs.id}");
				//	//   Console.WriteLine(rs.LoadPageLogo());
				//}
				//foreach (var rs in b.pixels)
				//	Console.WriteLine($"Name:{rs.name},id:{rs.id}");

				//Console.WriteLine(time.Elapsed);
				Campaign campaign = new Campaign(b, b.adAccounts.First(r => r.name == "1")) { name = "VasyaFirstApp", objective = Campaign.ENUM_OBJECTIVE.LINK_CLICKS, status = Campaign.CAMPAIGN_STATUS.PAUSED };
				string idCamp = campaign.SetCampaignToFacebook();
				AdSet adset = new AdSet(b, b.adAccounts.First(r => r.name == "1"))
				{
					name = "Vasilia",
					optimizationGoal = AdSet.OPTIMIZATION_GOAL.REACH,
					bidAmount = 2,
					billingEvent= AdSet.BILLING_EVENT.IMPRESSIONS,
					dailyBudget = "1000",
					campaignId = idCamp,
					targeting = new Targeting { geoLocations= new TargetingGeoLocation { countries= new List<string> { "US","RU" } } },
					status = AdSet.CONFIGURED_STATUS.PAUSED
				};
				Console.WriteLine(adset.SetAdSetToFacebook());

			}
			//Console.WriteLine(campaign.SetCampaignToFacebook());


			catch (WebException wex)
			{
				Console.WriteLine(wex.Response.Headers);
			}
			Console.ReadLine();
		}
	}
}
