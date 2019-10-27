using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingGeoLocationPoliticalDistrict
	{
		[JsonProperty("country")]
		public string country { get; set; } = null;
		[JsonProperty("key")]
		public string key { get; set; } = null;
		[JsonProperty("name")]
		public string name { get; set; } = null;
		[JsonProperty("political_district")]
		public string politicalDistrict { get; set; } = null;
	}
}
