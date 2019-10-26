using Fb.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Fb.Api.Models
{
	public class Campaign : BaseAdAccount
	{

		[JsonProperty("adlabels")]
		public List<AdLabel> mAdlabels { get; private set; } = null;
		[JsonProperty("bid_strategy")]
		public EENUM_BID_STRATEGY? mBidStrategy { get; private set; } = null;
		[JsonProperty("boosted_object_id")]
		public string mBoostedObjectId { get; private set; } = null;
		[JsonProperty("brand_lift_studies")]
		public List<AdStudy> brandLiftStudies { get; private set; } = null; //-- не загружается
		[JsonProperty("budget_rebalance_flag")]
		public bool? budgetRebalanceFlag { get; private set; } = null;
		[JsonProperty("budget_remaining")]
		public string budgetRemaining { get; private set; } = null;
		[JsonProperty("buying_type")]
		public string buyingType { get; private set; } = null;
		[JsonProperty("can_create_brand_lift_study")]
		public bool? canCreateBrandLiftStudy { get; private set; } = null;
		[JsonProperty("can_use_spend_cap")]
		public bool? canUseSpendCap { get; private set; } = null;
		[JsonProperty("configured_status")]
		public CAMPAIGN_STATUS? configuredStatus { get; private set; } = null;
		[JsonProperty("created_time")]
		public DateTime? сreatedTime { get; private set; } = null;
		[JsonProperty("daily_budget")]
		public string dailyBudget { get; private set; } = null; //-- загружается
		[JsonProperty("effective_status")]
		public ENUM_EFFECTIVE_STATUS? effectiveStatus { get; private set; } = null;
		[JsonProperty("issues_info")]
		public List<AdCampaignIssuesInfo> mIssuesInfo { get; private set; } = null;
		[JsonProperty("last_budget_toggling_time")]
		public string lastBudgetTogglingTime { get; private set; } = null;// -- не загружается
		[JsonProperty("lifetime_budget")]
		public string lifetimeBudget { get; private set; } = null; //- не загружается

		[JsonProperty("objective")]
		public string objective { get; private set; } = null;
		[JsonProperty("pacing_type")]
		public List<string> зacingType { get; private set; } = null; //-- не загружается
		//[JsonProperty("promoted_object")]
		//public AdPromotedObject mPromotedObject { get; private set; } = null;
		//[JsonProperty("recommendations")]
		//public List<AdRecommendation> mRecommendations { get; private set; } = null;
		[JsonProperty("source_campaign")]
		public Campaign sourceCampaign { get; private set; } = null;// -- не загружается
		[JsonProperty("source_campaign_id")]
		public string sourceCampaignId { get; private set; } = null;
		[JsonProperty("special_ad_category")]
		public string specialAdCategory { get; private set; } = null;
		[JsonProperty("spend_cap")]
		public string mSpendCap { get; private set; } = null; //-- не загружается
		[JsonProperty("start_time")]
		public string startTime { get; private set; } = null;
		[JsonProperty("status")]
		public CAMPAIGN_STATUS? status { get; private set; } = null;

		[JsonProperty("stop_time")]
		public string mStopTime { get; private set; } = null; //-- не загружается
		[JsonProperty("topline_id")]
		public string toplineId { get; private set; } = null;
		[JsonProperty("updated_time")]
		public string updatedTime { get; private set; } = null;
		public Campaign(Business business, AdAccount adAccount)
		{
			SetBusiness(business);
			SetAdAccount(adAccount);
		}
		public Campaign()
		{

		}
		//public string buying_type { get => "AUCTION"; set { buying_type = value; } }   // 

		public bool? SetCampaignToFacebook()
		{
			string request = business.account.baseUri + adAccount.id + this.ToString();
			return ParseJsonResponseHelper.ParseResultOrId(RequestHelper.SendGetRequest(request, business.account.postSettings)) != "Error" ? true : false;
		}
		public bool? UpdateCampaign()
		{
			return true;
		}
		public void SetStatus()
		{

		}

		#region ParamsNotEntity

		#endregion
		#region Enums
		public enum ENUM_EFFECTIVE_STATUS : int
		{
			ACTIVE,
			ARCHIVED,
			DELETED,
			IN_PROCESS,
			PAUSED,
			WITH_ISSUES
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
		public enum EENUM_BID_STRATEGY : int
		{
			VOWEST_COST_WITHOUT_CAP,
			LOWEST_COST_WITH_BID_CAP,
			TARGET_COST
		}
		#endregion


	}





}

