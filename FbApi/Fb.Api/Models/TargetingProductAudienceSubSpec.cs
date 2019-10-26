using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingProductAudienceSubSpec
	{
		[JsonProperty("retention_seconds")]
		public string mRetentionSeconds { get; private set; }
		[JsonProperty("rule")]
		public string mRule { get; private set; }
	}
}
