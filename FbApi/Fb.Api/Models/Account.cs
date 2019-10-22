using System;
using System.Collections.Generic;
using System.Text;
using Fb.Api.Helpers;
using System.Linq;
namespace Fb.Api.Models
{
    public class Account
    {
        private readonly string access_token;
        public readonly string baseUri = "https://graph.facebook.com/v4.0/";
        public HttpWEbRequestSettings postSettings { get; private set; }
        public HttpWEbRequestSettings getSettings { get; private set; }
        public List<Business> businesses { get; private set; } = new List<Business>();
        public Account(string token,bool loadInf=false)
        {
            access_token = token;
            SetDefaultSettingsRequests();
        }

        public string getToken()
        {
            return access_token;
        }
        private void SetBusinessesAccount()
        {
            foreach (var bus in businesses)
                bus.SetBusinessAccount(this);
        }
        public void SetPostRequestSettings(HttpWEbRequestSettings settings)
        {

        }
        public void SetGetRequestSettings(HttpWEbRequestSettings settings)
        {

        }
        private void SetDefaultSettingsRequests()
        {
            postSettings = new HttpWEbRequestSettings { requestMethod = "POST" };
            getSettings = new HttpWEbRequestSettings { requestMethod = "GET" };
        }
        public IEnumerable<Business> GetAllBusiness()
        {
            string request = baseUri + "me/" + "?fields=businesses&access_token=" + getToken();
            businesses = ParseJsonResponseHelper.ParseBusiness(RequestHelper.SendGetRequest(request, getSettings)).ToList();
            SetBusinessesAccount();
            return businesses;
        }
        
    }
}
