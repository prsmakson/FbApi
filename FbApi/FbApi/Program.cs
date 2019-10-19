using System;
using OpenQA.Selenium.Chrome;
using System.Net.Http;
using System.Threading.Tasks;

namespace FbApi
{
   
    class Program
    { 
        static readonly HttpClient client = new HttpClient();
        static async Task Main()
        {
            Console.WriteLine("Hello World!");
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://www.droidapps.ga/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
             
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
