using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCampaignFrequencyControlSpecs
	{
		[JsonProperty("event")]
		public string @event = null;
		[JsonProperty("interval_days")]
		public long? intervalDays = null;
		[JsonProperty("max_frequency")]
		public long? maxFrequency = null;
	}
}
