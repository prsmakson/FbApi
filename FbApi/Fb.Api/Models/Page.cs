using Fb.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
    public class Page : BaseBusiness
    {
        public string access_token { get; set; }

     
        public bool LoadPageLogo(string logoUri = "https://tursar.ru/image/img2095_0.jpg")
        {

            string request = business.account.baseUri + id + "/picture/?picture=" + logoUri + "&access_token=" + access_token;
            var requestResult = RequestHelper.SendPostRequest(request, business.account.postSettings);
            return ParseJsonResponseHelper.ParseResultPostRequest(requestResult);
        }
       
    }
}
