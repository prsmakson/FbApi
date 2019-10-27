using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingGeoLocationElectoralDistrict
	{
		[JsonProperty("country")]
		public string country { get; set; } = null;
		[JsonProperty("electoral_district")]
		public string electoralDistrict { get; set; } = null;
		[JsonProperty("key")]
		public string key { get; set; } = null;
		[JsonProperty("name")]
		public string name { get; set; } = null;
	}
}
