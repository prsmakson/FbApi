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
            string token = "EAABsbCS1iHgBAC7qYffG0hfQyvWMzwtQkZB8V3BeZCtaZCxW8TC1CFRHmk4qc9nP7PW89LGSZAXIQ4m5aF8pZCAyr1BTKeF9ZCeynSmTs5OMai6mXhgA4qnGzZASM9197E9O5c9TjffyxJn2UZCXtwhDCXq7ZBVVPdsfsByXKLzWQZCwZDZD";
            //string token = "EAABsbCS1iHgBAIfMBMUxWbC1PNHnlrWzXiIqTTemzhLqy0ZB4QZCmdoKBDhbZAyRs5Ft7jcvl6CuEAluGDNpbLivvJ6pS2rh2GJYMJoaUDpQ5ZCUJVoJMWVInTXg4JRusCh7JSXnfJs9JjmLZAOc7IywCp03sDaTuWEtBgpbk2Weg83jnj8inuXCeprJRdxIZD";
            try
            {
                Stopwatch time = new Stopwatch();
                time.Start();
                Account R = new Account(token);
               
                var business = R.GetAllBusiness().ToList();
                var b=business.First(r => r.name == "OlgaBus21");
				//b.LoadReferencesObject();
				b.GetAdAccounts();
				b.GetPages();
				b.GetPixels();
				time.Stop();
                foreach (var r in business)
                    Console.WriteLine($"Name:{r.name}, id: {r.id}");
				var AdAccounts = b.GetAdAccounts();
				foreach (var rs in b.adAccounts)
					Console.WriteLine($"Name:{rs.name},id:{rs.id},account_status:{rs.accountStatus}");
				foreach (var rs in b.pages)
				{

					Console.WriteLine($"Name:{rs.name},id:{rs.id}");
					//   Console.WriteLine(rs.LoadPageLogo());
				}
				foreach (var rs in b.pixels)
					Console.WriteLine($"Name:{rs.name},id:{rs.id}");

				Console.WriteLine(time.Elapsed);
				Campaign campaign = new Campaign(b,b.adAccounts.First(r=>r.name=="1")) { name = "VasyaFirstApp", objective = ENUM_OBJECTIVE.LINK_CLICKS, status = CAMPAIGN_STATUS.PAUSED };
				Console.WriteLine(campaign.SetCampaignToFacebook());
			}

            catch (WebException wex)
            { 
                Console.WriteLine(wex.Response.Headers); 
            }
            Console.ReadLine();
        }
    }
}
