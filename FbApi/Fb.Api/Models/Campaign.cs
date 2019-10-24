using Fb.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
    public class Campaign : BaseAdAccount
    {
        public Campaign(Business business, AdAccount adAccount)
        {
            SetBusiness(business);
            SetAdAccount(adAccount);
        }
        public Campaign()
        {

        }
        public string buying_type { get; set; } = "AUCTION"; // 

        public ENUM_OBJECTIVE objective { get; set; }
        public CAMPAIGN_STATUS status { get; set; }
        public  bool SetCampaignToFacebook()
        {
            string request = business.account.baseUri+adAccount.id + this.ToString();
            return ParseJsonResponseHelper.ParseResultOrId(RequestHelper.SendGetRequest(request, business.account.postSettings)) != "Error" ? true : false;
        }
        public bool UpdateCampaign()
        {
            return true;
        }
        public void SetStatus()
        {

        }

        #region ParamsNotEntity

        #endregion
        public override string ToString()
        {
            return $"/campaigns/?{nameof(name)}={name}&{nameof(objective)}={objective}&{nameof(status)}={status}&access_token={business.account.getToken()}";
        }


    }


    public enum ENUM_OBJECTIVE : int
    {
        APP_INSTALLS,
        BRAND_AWARENESS,
        CONVERSIONS,
        EVENT_RESPONSES,
        LEAD_GENERATION,
        LINK_CLICKS,
        LOCAL_AWARENESS,
        MESSAGES,
        OFFER_CLAIMS,
        PAGE_LIKES,
        POST_ENGAGEMENT,
        PRODUCT_CATALOG_SALES,
        REACH,
        VIDEO_VIEWS
    }
    public enum CAMPAIGN_STATUS : int
    { 
        ACTIVE,
        PAUSED,
        DELETED,
        ARCHIVED 
    }
   

}

