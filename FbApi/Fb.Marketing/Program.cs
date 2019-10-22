using System;
using System.Net.Http;
using Fb.Api;
using Fb.Api.Models;
using Fb.Api.Models.Exstension;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Fb.Marketing
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "EAABsbCS1iHgBAPSLeWhPLLP01OxtvT8LwoPyCUHBMpTCZBrUd6CrIonZB4UULmLZB8moaV80I7ml98atz4TC2sEEptfVdoggbwYwcTawpV6GgCWiZBCEs2dx8Bjvaf21ZCFsjGOavej2il2HW3i95k6dPpJ4PZAF9fTZANlMNlMqQZDZD";
            try
            {
                Account R = new Account(token);
                var business = R.GetAllBusiness().ToList();
                foreach (var r in business)
                    Console.WriteLine($"Name:{r.name}, id: {r.id}");
                foreach (var rs in business.First(a => a.name == "OlgaBus21").GetAdAccounts(R))
                    Console.WriteLine($"Name:{rs.name},id:{rs.id},account_status:{rs.account_status}");
                foreach (var rs in business.First(a => a.name == "OlgaBus21").GetPages(R))
                {

                    Console.WriteLine($"Name:{rs.name},id:{rs.id}");
                    Console.WriteLine(rs.LoadPageLogo(R));
                }
                foreach (var rs in business.First(a => a.name == "OlgaBus21").GetPixels(R))
                    Console.WriteLine($"Name:{rs.name},id:{rs.id}");
            }
            
            catch(WebException wex)
            { 
                Console.WriteLine(wex.Response.Headers); 
            }
            Console.ReadLine();
        }
    }
}
