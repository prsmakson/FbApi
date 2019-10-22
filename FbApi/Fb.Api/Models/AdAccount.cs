using System;
using System.Collections.Generic;
using System.Text;
using Fb.Api.Helpers;
namespace Fb.Api.Models
{
    public class AdAccount : BaseBusiness
    {
        public ACCOUNT_STATUS account_status { get; set; }

        #region ParamsNotEntity

        
        public IEnumerable<Campaign> campaigns { get; set; }
        public IEnumerable<Campaign> GetCampaigns()
        {
            string request = business.account.baseUri + "act_" + id + $"/campaigns/?fields=name,id&access_token=" + business.account.getToken();
            campaigns = ParseJsonResponseHelper.ParseCampaigns(RequestHelper.SendPostRequest(request, business.account.getSettings));
            SetCampaignBusinessAndAdAccount();
            return campaigns;
        }
        private void SetCampaignBusinessAndAdAccount()
        {
            foreach (var camp in campaigns)
            {
                camp.SetAdAccount(this);
                camp.SetBusiness(business);
            }
            
        }
        #endregion
    }
    public enum ACCOUNT_STATUS : int
    {
        ACTIVE = 1,
        DISABLED = 2,
        UNSETTLED = 3,
        PENDING_RISK_REVIEW = 7,
        PENDING_SETTLEMENT = 8,
        IN_GRACE_PERIOD = 9,
        PENDING_CLOSURE = 100,
        CLOSED = 101,
        ANY_ACTIVE = 201,
        ANY_CLOSED = 202
    }
}
