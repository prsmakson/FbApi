using System;
using System.Collections.Generic;
using System.Text;
using Fb.Api.Helpers;
using Fb.Api.Models;
namespace Fb.Api.Models.Exstension
{
    public static class PostClassExstension
    {

        //public static bool CreateCampaign(this AdAccount adAccount,Account account,Campaign campaign)
        //{
        //    string request= account.baseUri+adAccount.id+"/"
        //}
        public static bool LoadPageLogo(this Page page,Account account,string logoUri= "https://tursar.ru/image/img2095_0.jpg")
        {   
            
            string request = account.baseUri + page.id + "/picture/?picture="+logoUri+"&access_token="+page.access_token;
            var requestResult = SendPostRequest(request, account.postSettings);

            
                   
            return ParseJsonResponseHelper.ParseResultPostRequest(requestResult);
        }
        private static string SendPostRequest(string request,HttpWEbRequestSettings settings)
        {
            return  RequestHelper.SendRequest(request, settings);
        }
    }
}
