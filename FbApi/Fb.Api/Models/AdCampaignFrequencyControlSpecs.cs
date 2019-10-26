using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCampaignFrequencyControlSpecs
	{
		[JsonProperty("event")]
		public string mEvent = null;
		[JsonProperty("interval_days")]
		public long? mIntervalDays = null;
		[JsonProperty("max_frequency")]
		public long? mMaxFrequency = null;
	}
}
