using System;
using System.Collections.Generic;
using System.Text;
using Fb.Api.Helpers;
using Fb.Api.Models.Exstension;
using Fb.Api.Models.Intf;
using Newtonsoft.Json;

namespace Fb.Api.Models
{
	public class AdSet : IAdAccount, IBusiness, INameID
	{
		[JsonProperty("name")]
		public string name { get; set; } = null;
		[JsonProperty("id")]
		public string id { get; set; } = null;
		[JsonProperty("adlabels")]
		public List<AdLabel> adlabels { get; private set; } = null;
		[JsonProperty("adset_schedule")]
		public List<DayPart> adsetSchedule { get; private set; } = null;
		[JsonProperty("asset_feed_id")]
		public string assetFeedId { get; private set; } = null;
		[JsonProperty("attribution_spec")]
		public List<AttributionSpec> attributionSpec { get; private set; } = null;
		[JsonProperty("bid_adjustments")]
		public AdBidAdjustments bidAdjustments { get; private set; } = null;
		[JsonProperty("bid_amount")]
		public long? bidAmount { get; set; } = null;
		[JsonProperty("bid_constraints")]
		public AdCampaignBidConstraint bidConstraints { get; private set; } = null;
		[JsonProperty("bid_info")]
		public Dictionary<string, long> bidInfo { get; private set; } = null;
		[JsonProperty("bid_strategy")]
		public BID_STRATEGY? bidStrategy { get; private set; } = null;
		[JsonProperty("billing_event")]
		public BILLING_EVENT? billingEvent { get; set; } = null;
		[JsonProperty("budget_remaining")]
		public string budgetRemaining { get; private set; } = null;

		[JsonProperty("campaign_id")]
		public string campaignId { get; set; } = null;
		[JsonProperty("configured_status")]
		public CONFIGURED_STATUS? configuredStatus { get; private set; } = null;
		[JsonProperty("created_time")]
		public string createdTime { get; private set; } = null;
		[JsonProperty("creative_sequence")]
		public List<string> creativeSequence { get; private set; } = null;
		[JsonProperty("daily_budget")]
		public string dailyBudget { get;set; } = null;
		[JsonProperty("daily_min_spend_target")]
		public string dailyMinSpendTarget { get; private set; } = null;
		[JsonProperty("daily_spend_cap")]
		public string dailySpendCap { get; private set; } = null;
		[JsonProperty("destination_type")]
		public string destinationType { get; private set; } = null;
		[JsonProperty("effective_status")]
		public ENUM_EFFECTIVE_STATUS? effectiveStatus { get; private set; } = null;
		[JsonProperty("end_time")]
		public DateTime? endTime { get; private set; } = null;
		[JsonProperty("frequency_control_specs")]
		public List<AdCampaignFrequencyControlSpecs> frequencyControlSpecs { get; private set; } = null;
		[JsonProperty("full_funnel_exploration_mode")]
		public string fullFunnelExplorationMode { get; private set; } = null;
		[JsonProperty("instagram_actor_id")]
		public string instagramActorId { get; private set; } = null;
		[JsonProperty("is_dynamic_creative")]
		public bool? isDynamicCreative { get; private set; } = null;
		[JsonProperty("issues_info")]
		public List<AdCampaignIssuesInfo> mIssuesInfo { get; private set; } = null;
		[JsonProperty("lifetime_budget")]
		public string lifetimeBudget { get; private set; } = null;
		[JsonProperty("lifetime_imps")]
		public long? lifetimeImps { get; private set; } = null;
		[JsonProperty("lifetime_min_spend_target")]
		public string lifetimeMinSpendTarget { get; private set; } = null;
		[JsonProperty("lifetime_spend_cap")]
		public string lifetimeSpendCap { get; private set; } = null;
		[JsonProperty("optimization_goal")]
		public OPTIMIZATION_GOAL? optimizationGoal { get;set; } = null;
		[JsonProperty("optimization_sub_event")]
		public string optimizationSubEvent { get; private set; } = null;
		[JsonProperty("pacing_type")]
		public List<string> pacingType { get; private set; } = null;
		//[JsonProperty("promoted_object")]
		//public AdPromotedObject mPromotedObject { get; private set; } = null;
		//[JsonProperty("recommendations")]
		// public List<AdRecommendation> mRecommendations { get; private set; } = null;
		[JsonProperty("recurring_budget_semantics")]
		public bool? recurringBudgetSemantics { get; private set; } = null;
		[JsonProperty("review_feedback")]
		public string reviewFeedback { get; private set; } = null;
		[JsonProperty("rf_prediction_id")]
		public string rfPredictionId { get; private set; } = null;
		[JsonProperty("source_adset")]
		public AdSet sourceAdset { get; private set; } = null;
		[JsonProperty("source_adset_id")]
		public string sourceAdsetId { get; private set; } = null;
		[JsonProperty("start_time")]
		public DateTime? startTime { get; private set; } = null;
		[JsonProperty("status")]
		public CONFIGURED_STATUS? status { get; set; } = null;
		[JsonProperty("targeting")]
		public Targeting targeting { get;  set; } = null;
		[JsonProperty("time_based_ad_rotation_id_blocks")]
		public List<List<long>> timeBasedAdRotationIdBlocks { get; private set; } = null;
		[JsonProperty("time_based_ad_rotation_intervals")]
		public List<long> timeBasedAdRotationIntervals { get; private set; } = null;
		[JsonProperty("updated_time")]
		public DateTime? updatedTime { get; private set; } = null;
		[JsonProperty("use_new_app_click")]
		public bool? useNewAppClick { get; private set; } = null;
		#region ParamsNotEntity
		[JsonProperty("campaign")]
		public Campaign campaign { get; private set; } = null;
		[JsonProperty("account_id")]
		public string accountId { get; private set; }
		public AdAccount adAccount { get; private set; }
		public Business business { get; private set; }
		public void SetAdAccount(AdAccount adAccount)
		{
			this.adAccount = adAccount;
		}
		public void SetBusiness(Business business)
		{
			this.business = business;
		}
		public void SetCampaign(Campaign campaign)
		{
			this.campaign = campaign;
			campaignId = campaign.id;
		}
		public AdSet() { }
		public AdSet(Business business,AdAccount adAccount)
		{
			SetAdAccount(adAccount);
			SetBusiness(business);
		}
		public string SetAdSetToFacebook()
		{
			string request = business.account.baseUri + adAccount.id + $"/adsets/?{typeof(AdSet).GetRequestPostString(this)}" + $"&access_token={business.account.getToken()}";
			return ParseJsonResponseHelper.ParseResultOrId(RequestHelper.SendGetRequest(request, business.account.postSettings));
		}
		#endregion
		#region enums
		public enum ENUM_EFFECTIVE_STATUS : int
		{
			ACTIVE,
			ARCHIVED,
			CAMPAIGN_PAUSED,
			DELETED,
			IN_PROCESS,
			PAUSED,
			WITH_ISSUES,
		}
		public enum CONFIGURED_STATUS
		{
			[JsonProperty("ACTIVE")]
			ACTIVE,
			[JsonProperty("PAUSED")]
			PAUSED,
			[JsonProperty("DELETED")]
			DELETED,
			[JsonProperty("ARCHIVED")]
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
			[JsonProperty("NONE")]
			NONE,
			[JsonProperty("APP_INSTALLS")]
			APP_INSTALLS,
			[JsonProperty("BRAND_AWARENESS")]
			BRAND_AWARENESS,
			[JsonProperty("AD_RECALL_LIFT")]
			AD_RECALL_LIFT,
			[JsonProperty("CLICKS")]
			CLICKS,
			[JsonProperty("ENGAGED_USERS")]
			ENGAGED_USERS,
			[JsonProperty("EVENT_RESPONSES")]
			EVENT_RESPONSES,
			[JsonProperty("IMPRESSIONS")]
			IMPRESSIONS,
			[JsonProperty("LEAD_GENERATION")]
			LEAD_GENERATION,
			[JsonProperty("LINK_CLICKS")]
			LINK_CLICKS,
			[JsonProperty("OFFER_CLAIMS")]
			OFFER_CLAIMS,
			[JsonProperty("OFFSITE_CONVERSIONS")]
			OFFSITE_CONVERSIONS,
			[JsonProperty("PAGE_ENGAGEMENT")]
			PAGE_ENGAGEMENT,
			[JsonProperty("PAGE_LIKES")]
			PAGE_LIKES,
			[JsonProperty("POST_ENGAGEMENT")]
			POST_ENGAGEMENT,
			[JsonProperty("REACH")]
			REACH,
			[JsonProperty("OCIAL_IMPRESSIONS")]
			OCIAL_IMPRESSIONS,
			[JsonProperty("VIDEO_VIEWS")]
			VIDEO_VIEWS,
			[JsonProperty("APP_DOWNLOADS")]
			APP_DOWNLOADS,
			[JsonProperty("TWO_SECOND_CONTINUOUS_VIDEO_VIEWS")]
			TWO_SECOND_CONTINUOUS_VIDEO_VIEWS,
			[JsonProperty("LANDING_PAGE_VIEWS")]
			LANDING_PAGE_VIEWS,
			[JsonProperty("VALUE")]
			VALUE,
			[JsonProperty("THRUPLAY")]
			THRUPLAY,
			[JsonProperty("REPLIES")]
			REPLIES,
			[JsonProperty("DERIVED_EVENTS")]
			DERIVED_EVENTS
		}
		public enum BILLING_EVENT
		{	[JsonProperty("APP_INSTALLS")]
			APP_INSTALLS,
			[JsonProperty("CLICKS")]
			CLICKS,
			[JsonProperty("IMPRESSIONS")]
			IMPRESSIONS,
			[JsonProperty("LINK_CLICKS")]
			LINK_CLICKS,
			[JsonProperty("NONE")]
			NONE,
			[JsonProperty("OFFER_CLAIMS")]
			OFFER_CLAIMS,
			[JsonProperty("PAGE_LIKES")]
			PAGE_LIKES,
			[JsonProperty("POST_ENGAGEMENT")]
			POST_ENGAGEMENT,
			[JsonProperty("VIDEO_VIEWS")]
			VIDEO_VIEWS,
			[JsonProperty("THRUPLAY")]
			THRUPLAY
		}
		#endregion

	}


}
