using System;
using System.Collections.Generic;
using System.Text;
using Fb.Api.Helpers;
using System.Linq;
using Fb.Api.Models.Exstension;
namespace Fb.Api.Models
{
	public class Account
	{
		private readonly string access_token;
		public string baseUri { get => "https://graph.facebook.com/" + apiVersion+"/"; }
		public readonly string apiVersion = "v4.0";
		public HttpWEbRequestSettings postSettings { get; private set; }
		public HttpWEbRequestSettings getSettings { get; private set; }
		public List<Business> businesses { get; private set; } = new List<Business>();
		public Account(string token,string versionApi, bool loadInf = false)
		{
			access_token = token;
			apiVersion = versionApi;
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
			postSettings = settings;
		}
		public void SetGetRequestSettings(HttpWEbRequestSettings settings)
		{
			getSettings = settings;
		}
		private void SetDefaultSettingsRequests()
		{
			postSettings = new HttpWEbRequestSettings { requestMethod = "POST" };
			getSettings = new HttpWEbRequestSettings { requestMethod = "GET" };
		}
		public IEnumerable<Business> GetAllBusiness()
		{
			string request = baseUri + "me/" + $"businesses/?fields={typeof(Business).GetRequestGetstring()}&access_token=" + getToken();
			businesses = ParseJsonResponseHelper.ParseBusiness(RequestHelper.SendGetRequest(request, getSettings)).ToList();
			SetBusinessesAccount();
			return businesses;
		}

	}
}
