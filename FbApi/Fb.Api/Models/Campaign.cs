using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
    class Campaign : BaseBusiness
    {

        public string buying_type { get; set; } = "AUCTION"; // 

        public ENUM_OBJECTIVE objective { get; set; }
        #region ParamsNotEntity
        
        #endregion
        //public  override string ToString()
        //{

        //}
        

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

