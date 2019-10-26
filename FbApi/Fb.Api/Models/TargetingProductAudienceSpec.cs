using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingProductAudienceSpec
	{
		[JsonProperty("exclusions")]
		public List<TargetingProductAudienceSubSpec> mExclusions = null;
		[JsonProperty("inclusions")]
		public List<TargetingProductAudienceSubSpec> mInclusions = null;
		[JsonProperty("product_set_id")]
		public string mProductSetId = null;
	}
}
