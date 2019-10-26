using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingDynamicRule
	{
		[JsonProperty("action.type")]
		public string mActionType { get; private set; } = null; 
		[JsonProperty("ad_group_id")]
		public string mAdGroupId { get; private set; } = null; 
		[JsonProperty("campaign_group_id")]
		public string mCampaignGroupId { get; private set; } = null; 
		[JsonProperty("campaign_id")]
		public string mCampaignId { get; private set; } = null; 
		[JsonProperty("impression_count")]
		public string mImpressionCount { get; private set; } = null; 
		[JsonProperty("page_id")]
		public string mPageId { get; private set; } = null; 
		[JsonProperty("post")]
		public string mPost { get; private set; } = null; 
		[JsonProperty("retention_seconds")]
		public string mRetentionSeconds { get; private set; } = null; 
	}
}
