using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	class Ad : BaseAdAccount
	{

		[JsonProperty("ad_review_feedback")]
		public AdgroupReviewFeedback adReviewFeedback { get; private set; } = null;
		[JsonProperty("adlabels")]
		public IEnumerable<AdLabel> adlabels { get; private set; } = null;
		[JsonProperty("adset")]
		public AdSet adset { get; private set; } = null;
		[JsonProperty("adset_id")]
		public string adsetId { get; private set; } = null;
		[JsonProperty("bid_amount")]
		public long? bidAmount { get; private set; } = null;
		[JsonProperty("bid_info")]
		public Dictionary<string, long> bidInfo { get; private set; } = null;
		[JsonProperty("bid_type")]
		public ENUM_BID_TYPE? bidType { get; private set; } = null;
		[JsonProperty("campaign")]
		public Campaign campaign { get; private set; } = null;
		[JsonProperty("campaign_id")]
		public string campaignId { get; private set; } = null;
		[JsonProperty("configured_status")]
		public ENUM_CONFIGURED_STATUS? configuredStatus { get; private set; } = null;
		[JsonProperty("conversion_specs")]
		public IEnumerable<ConversionActionQuery> conversionSpecs { get; private set; } = null;
		[JsonProperty("created_time")]
		public string createdTime { get; private set; } = null;
		[JsonProperty("creative")]
		public AdCreative creative { get; private set; } = null;
		[JsonProperty("demolink_hash")]
		public string demolinkHash { get; private set; } = null;
		[JsonProperty("display_sequence")]
		public long? displaySequence { get; private set; } = null;
		[JsonProperty("effective_status")]
		public ENUM_EFFECTIVE_STATUS? effectiveStatus { get; private set; } = null;
		[JsonProperty("engagement_audience")]
		public bool? engagementAudience { get; private set; } = null;
		[JsonProperty("failed_delivery_checks")]
		public IEnumerable<DeliveryCheck> failedDeliveryChecks { get; private set; } = null;

		[JsonProperty("is_autobid")]
		public bool? isAutobid { get; private set; } = null;
		[JsonProperty("issues_info")]

		public IEnumerable<AdgroupIssuesInfo> issuesInfo { get; private set; } = null;
		[JsonProperty("last_updated_by_app_id")]
		public string lastUpdatedByAppId { get; private set; } = null;

		[JsonProperty("preview_shareable_link")]
		public string previewShareableLink { get; private set; } = null;
		[JsonProperty("priority")]
		public long? priority { get; private set; } = null;
		[JsonProperty("recommendations")]
		public IEnumerable<AdRecommendation> recommendations { get; private set; } = null;
		[JsonProperty("source_ad")]
		public Ad sourceAd { get; private set; } = null;
		[JsonProperty("source_ad_id")]
		public string sourceAdId { get; private set; } = null;
		[JsonProperty("status")]
		public ENUM_STATUS? status { get; private set; } = null;
		[JsonProperty("targeting")]
		public Targeting targeting { get; private set; } = null;
		[JsonProperty("tracking_and_conversion_with_defaults")]
		public TrackingAndConversionWithDefaults trackingAndConversionWithDefaults { get; private set; } = null;
		[JsonProperty("tracking_specs")]
		public IEnumerable<ConversionActionQuery> trackingSpecs { get; private set; } = null;
		[JsonProperty("updated_time")]
		public string updatedTime { get; private set; } = null;
		#region enums
		public enum ENUM_BID_TYPE : int
		{
			ABSOLUTE_OCPM,
			CPA,
			CPC,
			CPM,
			MULTI_PREMIUM
		}
		public enum ENUM_CONFIGURED_STATUS : int
		{
			ACTIVE,
			ARCHIVED,
			DELETED,
			PAUSED


		}
		public enum ENUM_EFFECTIVE_STATUS : int
		{
			ACTIVE,
			ADSET_PAUSED,
			ARCHIVED,
			CAMPAIGN_PAUSED,
			DELETED,
			DISAPPROVED,
			IN_PROCESS,
			PAUSED,
			PENDING_BILLING_INFO,
			PENDING_REVIEW,
			PREAPPROVED,
			WITH_ISSUES
		}
		public enum ENUM_STATUS : int
		{
			ACTIVE,
			ARCHIVED,
			DELETED,
			PAUSED


		}
		#endregion
	}
}
