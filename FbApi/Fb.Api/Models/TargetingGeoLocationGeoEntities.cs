using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingGeoLocationGeoEntities
	{
		[JsonProperty("country")]
		public string cuntry { get; set; } = null;
		[JsonProperty("key")]
		public string key { get; set; } = null;
		[JsonProperty("name")]
		public string name { get; set; } = null;
		[JsonProperty("region")]
		public string region { get; set; } = null;
		[JsonProperty("region_id")]
		public string regionId { get; set; } = null;
	}
}
