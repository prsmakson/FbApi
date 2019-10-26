using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class DeliveryCheckExtraInfo
	{
		[JsonProperty("adgroup_ids")]
		public IEnumerable<String> adgroupIds { get; private set; } = null;
		[JsonProperty("campaign_ids")]
		public IEnumerable<string> campaignIds { get; private set; } = null;
		[JsonProperty("countries")]
		public IEnumerable<string> countries { get; private set; } = null;
	}
}
