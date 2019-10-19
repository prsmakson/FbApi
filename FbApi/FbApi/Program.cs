using System;
using System.Net.Http;
using FbApi.Models.Exstension;
using FbApi.Models;
namespace FbApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "EAABsbCS1iHgBAPSLeWhPLLP01OxtvT8LwoPyCUHBMpTCZBrUd6CrIonZB4UULmLZB8moaV80I7ml98atz4TC2sEEptfVdoggbwYwcTawpV6GgCWiZBCEs2dx8Bjvaf21ZCFsjGOavej2il2HW3i95k6dPpJ4PZAF9fTZANlMNlMqQZDZD";
            Account R = new Account(token);
            foreach (var r in R.GetAllBusiness())
                Console.WriteLine($"Name:{r.name}, id: {r.id}");
            Console.ReadLine();
        }
    }
}
