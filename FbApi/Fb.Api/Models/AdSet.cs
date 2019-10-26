using System;
using System.Collections.Generic;
using System.Text;
using Fb.Api.Models.Intf;
using Newtonsoft.Json;

namespace Fb.Api.Models
{
	public class AdSet : BaseAdAccount, ICampaign
	{

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
		public long? bidAmount { get; private set; } = null;
		[JsonProperty("bid_constraints")]
		public AdCampaignBidConstraint bidConstraints { get; private set; } = null;
		[JsonProperty("bid_info")]
		public Dictionary<string, long> bidInfo { get; private set; } = null;
		[JsonProperty("bid_strategy")]
		public BID_STRATEGY? bidStrategy { get; private set; } = null;
		[JsonProperty("billing_event")]
		public BILLING_EVENT? billingEvent { get; private set; } = null;
		[JsonProperty("budget_remaining")]
		public string budgetRemaining { get; private set; } = null;

		[JsonProperty("campaign_id")]
		public string campaignId { get; private set; } = null;
		[JsonProperty("configured_status")]
		public CONFIGURED_STATUS? configuredStatus { get; private set; } = null;
		[JsonProperty("created_time")]
		public string createdTime { get; private set; } = null;
		[JsonProperty("creative_sequence")]
		public List<string> creativeSequence { get; private set; } = null;
		[JsonProperty("daily_budget")]
		public string dailyBudget { get; private set; } = null;
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
		public OPTIMIZATION_GOAL? mOptimizationGoal { get; private set; } = null;
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
		public CONFIGURED_STATUS? status { get; private set; } = null;
		[JsonProperty("targeting")]
		public Targeting targeting { get; private set; } = null;
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

		public void SetCampaign(Campaign campaign)
		{
			this.campaign = campaign;
			campaignId = campaign.id;
		}
		#endregion
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
