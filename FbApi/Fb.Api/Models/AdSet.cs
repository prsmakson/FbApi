using System;
using System.Collections.Generic;
using System.Text;
using Fb.Api.Models.Intf;
namespace Fb.Api.Models
{
    public class AdSet : BaseAdAccount, ICampaign
    {
        public OPTIMIZATION_GOAL optimization_goal { get; set; }
        public int bid_amount { get; set; }
        public int daily_budget { get; set; }
        public string campaign_id { get; set; }
        public BID_STRATEGY bid_strategy { get; set; }
        #region ParamsNotEntity
        public Campaign campaign { get; private set; }

        public void SetCampaign(Campaign campaign)
        {
            this.campaign = campaign;
            campaign_id = campaign.id;
        }
        #endregion
    }
    public class Targeting
    {
        IEnumerable<string> genders { get; set; }
        public int age_min { get; set; }
        public int age_max { get; set; }
        IEnumerable<string> device_platforms { get; set; }
        IEnumerable<string> publisher_platforms { get; set; }

    }
    public class TargetingGeoLocation
    {

    }
    public enum CONFIGURED_STATUS
    {
        ACTIVE,
        PAUSED,
        DELETED,
        ARCHIVED
    }
    public enum BID_STRATEGY : int
    {
        LOWEST_COST_WITHOUT_CAP,
        LOWEST_COST_WITH_BID_CAP,
        TARGET_COST
    }


    public enum OPTIMIZATION_GOAL : int
    {
        NONE,
        APP_INSTALLS,
        BRAND_AWARENESS,
        AD_RECALL_LIFT,
        CLICKS,
        ENGAGED_USERS,
        EVENT_RESPONSES,
        IMPRESSIONS,
        LEAD_GENERATION,
        LINK_CLICKS,
        OFFER_CLAIMS,
        OFFSITE_CONVERSIONS,
        PAGE_ENGAGEMENT,
        PAGE_LIKES,
        POST_ENGAGEMENT,
        REACH,
        OCIAL_IMPRESSIONS,
        VIDEO_VIEWS,
        APP_DOWNLOADS,
        TWO_SECOND_CONTINUOUS_VIDEO_VIEWS,
        LANDING_PAGE_VIEWS,
        VALUE,
        THRUPLAY,
        REPLIES,
        DERIVED_EVENTS
    }
    public enum BILLING_EVENT
    {
        APP_INSTALLS,
        CLICKS,
        IMPRESSIONS,
        LINK_CLICKS,
        NONE,
        OFFER_CLAIMS,
        PAGE_LIKES,
        POST_ENGAGEMENT,
        VIDEO_VIEWS,
        THRUPLAY
    }
}
