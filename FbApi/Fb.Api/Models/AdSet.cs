using System;
using System.Collections.Generic;
using System.Text;
using Fb.Api.Models.Intf;
using Newtonsoft.Json;

namespace Fb.Api.Models
{
	public class AdSet : BaseAdAccount, ICampaign
	{
		[JsonProperty("account_id")]
		public string mAccountId { get; private set; } = null;
		[JsonProperty("adlabels")]
		public List<AdLabel> mAdlabels { get; private set; } = null;
		[JsonProperty("adset_schedule")]
		public List<DayPart> mAdsetSchedule { get; private set; } = null;
		[JsonProperty("asset_feed_id")]
		public string mAssetFeedId { get; private set; } = null;
		[JsonProperty("attribution_spec")]
		public List<AttributionSpec> mAttributionSpec { get; private set; } = null;
		[JsonProperty("bid_adjustments")]
		public AdBidAdjustments mBidAdjustments { get; private set; } = null;
		[JsonProperty("bid_amount")]
		public long? mBidAmount { get; private set; } = null;
		[JsonProperty("bid_constraints")]
		public AdCampaignBidConstraint mBidConstraints { get; private set; } = null;
		[JsonProperty("bid_info")]
		public Dictionary<string, long> mBidInfo { get; private set; } = null;
		[JsonProperty("bid_strategy")]
		public BID_STRATEGY? mBidStrategy { get; private set; } = null;
		[JsonProperty("billing_event")]
		public BILLING_EVENT? mBillingEvent { get; private set; } = null;
		[JsonProperty("budget_remaining")]
		public string mBudgetRemaining { get; private set; } = null;
		[JsonProperty("campaign")]
		public Campaign mCampaign { get; private set; } = null;
		[JsonProperty("campaign_id")]
		public string mCampaignId { get; private set; } = null;
		[JsonProperty("configured_status")]
		public CONFIGURED_STATUS? mConfiguredStatus { get; private set; } = null;
		[JsonProperty("created_time")]
		public string mCreatedTime { get; private set; } = null;
		[JsonProperty("creative_sequence")]
		public List<string> mCreativeSequence { get; private set; } = null;
		[JsonProperty("daily_budget")]
		public string mDailyBudget { get; private set; } = null;
		[JsonProperty("daily_min_spend_target")]
		public string mDailyMinSpendTarget { get; private set; } = null;
		[JsonProperty("daily_spend_cap")]
		public string mDailySpendCap { get; private set; } = null;
		[JsonProperty("destination_type")]
		public string mDestinationType { get; private set; } = null;
		[JsonProperty("effective_status")]
		public ENUM_EFFECTIVE_STATUS? mEffectiveStatus { get; private set; } = null;
		[JsonProperty("end_time")]
		public string mEndTime { get; private set; } = null;
		[JsonProperty("frequency_control_specs")]
		public List<AdCampaignFrequencyControlSpecs> mFrequencyControlSpecs { get; private set; } = null;
		[JsonProperty("full_funnel_exploration_mode")]
		public string mFullFunnelExplorationMode { get; private set; } = null;
		[JsonProperty("id")]
		public string mId { get; private set; } = null;
		[JsonProperty("instagram_actor_id")]
		public string mInstagramActorId { get; private set; } = null;
		[JsonProperty("is_dynamic_creative")]
		public bool? mIsDynamicCreative { get; private set; } = null;
		[JsonProperty("issues_info")]
		public List<AdCampaignIssuesInfo> mIssuesInfo { get; private set; } = null;
		[JsonProperty("lifetime_budget")]
		public string mLifetimeBudget { get; private set; } = null;
		[JsonProperty("lifetime_imps")]
		public long? mLifetimeImps { get; private set; } = null;
		[JsonProperty("lifetime_min_spend_target")]
		public string mLifetimeMinSpendTarget { get; private set; } = null;
		[JsonProperty("lifetime_spend_cap")]
		public string mLifetimeSpendCap { get; private set; } = null;
		[JsonProperty("name")]
		public string mName { get; private set; } = null;
		//	[JsonProperty("optimization_goal")]
		// EnumOptimizationGoal mOptimizationGoal { get; private set; } = null;
		[JsonProperty("optimization_sub_event")]
		public string mOptimizationSubEvent { get; private set; } = null;
		[JsonProperty("pacing_type")]
		public List<string> mPacingType { get; private set; } = null;
		//[JsonProperty("promoted_object")]
		//public AdPromotedObject mPromotedObject { get; private set; } = null;
		//[JsonProperty("recommendations")]
		// public List<AdRecommendation> mRecommendations { get; private set; } = null;
		[JsonProperty("recurring_budget_semantics")]
		public bool? mRecurringBudgetSemantics { get; private set; } = null;
		[JsonProperty("review_feedback")]
		public string mReviewFeedback { get; private set; } = null;
		[JsonProperty("rf_prediction_id")]
		public string mRfPredictionId { get; private set; } = null;
		[JsonProperty("source_adset")]
		public AdSet mSourceAdset { get; private set; } = null;
		[JsonProperty("source_adset_id")]
		public string mSourceAdsetId { get; private set; } = null;
		[JsonProperty("start_time")]
		public string mStartTime { get; private set; } = null;
		[JsonProperty("status")]
		public CONFIGURED_STATUS? mStatus { get; private set; } = null;
		[JsonProperty("targeting")]
		public Targeting mTargeting { get; private set; } = null;
		[JsonProperty("time_based_ad_rotation_id_blocks")]
		public List<List<long>> mTimeBasedAdRotationIdBlocks { get; private set; } = null;
		[JsonProperty("time_based_ad_rotation_intervals")]
		public List<long> mTimeBasedAdRotationIntervals { get; private set; } = null;
		[JsonProperty("updated_time")]
		public string mUpdatedTime { get; private set; } = null;
		[JsonProperty("use_new_app_click")]
		public bool? mUseNewAppClick { get; private set; } = null;
		#region ParamsNotEntity
		public Campaign campaign { get; private set; }

		public void SetCampaign(Campaign campaign)
		{
			this.campaign = campaign;
			// = campaign.id;
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
