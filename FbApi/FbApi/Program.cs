using System;
using System.Net.Http;
using FbApi.Models.Exstension;
using FbApi.Models;
using System.Collections.Generic;
using System.Linq;
namespace FbApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "EAABsbCS1iHgBAPSLeWhPLLP01OxtvT8LwoPyCUHBMpTCZBrUd6CrIonZB4UULmLZB8moaV80I7ml98atz4TC2sEEptfVdoggbwYwcTawpV6GgCWiZBCEs2dx8Bjvaf21ZCFsjGOavej2il2HW3i95k6dPpJ4PZAF9fTZANlMNlMqQZDZD";
            Account R = new Account(token);
            var business = R.GetAllBusiness().ToList();
            foreach (var r in business) 
                Console.WriteLine($"Name:{r.name}, id: {r.id}");
            foreach (var rs in R.GetAdAccounts(business.First(a=>a.name== "OlgaBus21").id))
                Console.WriteLine($"Name:{rs.name},id:{rs.id},account_status:{rs.account_status}");
            Console.ReadLine();
        }
    }
}
