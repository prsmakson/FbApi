using Fb.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Fb.Api.Models
{
	public class Campaign : BaseAdAccount
	{

		[JsonProperty("adlabels")]
		private List<AdLabel> mAdlabels = null;
		[JsonProperty("bid_strategy")]
		private EENUM_BID_STRATEGY? mBidStrategy = null;
		[JsonProperty("boosted_object_id")]
		private string mBoostedObjectId = null;
		[JsonProperty("brand_lift_studies")]
		private List<AdStudy> mBrandLiftStudies = null;
		[JsonProperty("budget_rebalance_flag")]
		private bool? mBudgetRebalanceFlag = null;
		[JsonProperty("budget_remaining")]
		private string mBudgetRemaining = null;
		[JsonProperty("buying_type")]
		private string mBuyingType = null;
		[JsonProperty("can_create_brand_lift_study")]
		private bool? mCanCreateBrandLiftStudy = null;
		[JsonProperty("can_use_spend_cap")]
		private bool? mCanUseSpendCap = null;
		[JsonProperty("configured_status")]
		private CAMPAIGN_STATUS? mConfiguredStatus = null;
		[JsonProperty("created_time")]
		private string mCreatedTime = null;
		[JsonProperty("daily_budget")]
		private string mDailyBudget = null;
		[JsonProperty("effective_status")]
		private ENUM_EFFECTIVE_STATUS? mEffectiveStatus = null;
		//[JsonProperty("issues_info")]
		//private List<AdCampaignIssuesInfo> mIssuesInfo = null;
		[JsonProperty("last_budget_toggling_time")]
		private string mLastBudgetTogglingTime = null;
		[JsonProperty("lifetime_budget")]
		private string mLifetimeBudget = null;
		[JsonProperty("name")]
		private string mName = null;
		[JsonProperty("objective")]
		private string mObjective = null;
		[JsonProperty("pacing_type")]
		private List<string> mPacingType = null;
		//[JsonProperty("promoted_object")]
		//private AdPromotedObject mPromotedObject = null;
		//[JsonProperty("recommendations")]
		//private List<AdRecommendation> mRecommendations = null;
		[JsonProperty("source_campaign")]
		private Campaign mSourceCampaign = null;
		[JsonProperty("source_campaign_id")]
		private string mSourceCampaignId = null;
		[JsonProperty("special_ad_category")]
		private string mSpecialAdCategory = null;
		[JsonProperty("spend_cap")]
		private string mSpendCap = null;
		[JsonProperty("start_time")]
		private string mStartTime = null;
		[JsonProperty("status")]
		private CAMPAIGN_STATUS? mStatus = null;
		[JsonProperty("stop_time")]
		private string mStopTime = null;
		[JsonProperty("topline_id")]
		private string mToplineId = null;
		[JsonProperty("updated_time")]
		private string mUpdatedTime = null;
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
		public override string ToString()
		{
			return $"/campaigns/?{nameof(name)}={name}&{nameof(objective)}={objective}&{nameof(status)}={status}&access_token={business.account.getToken()}";
		}


	}

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



}

