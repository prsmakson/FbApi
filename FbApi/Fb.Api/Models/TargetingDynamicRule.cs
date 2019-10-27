using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingDynamicRule
	{
		[JsonProperty("action.type")]
		public string actionType { get; private set; } = null; 
		[JsonProperty("ad_group_id")]
		public string adGroupId { get; private set; } = null; 
		[JsonProperty("campaign_group_id")]
		public string campaignGroupId { get; private set; } = null; 
		[JsonProperty("campaign_id")]
		public string campaignId { get; private set; } = null; 
		[JsonProperty("impression_count")]
		public string impressionCount { get; private set; } = null; 
		[JsonProperty("page_id")]
		public string pageId { get; private set; } = null; 
		[JsonProperty("post")]
		public string post { get; private set; } = null; 
		[JsonProperty("retention_seconds")]
		public string retentionSeconds { get; private set; } = null; 
	}
}
