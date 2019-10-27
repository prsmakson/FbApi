using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingGeoLocationCity
	{
		[JsonProperty("country")]
		public string country { get; set; } = null;
		[JsonProperty("distance_unit")]
		public string distanceUnit { get; set; } = null;
		[JsonProperty("key")]
		public string key { get; set; } = null;
		[JsonProperty("name")]
		public string name { get; set; } = null;
		[JsonProperty("radius")]
		public long? radius { get; set; } = null;
		[JsonProperty("region")]
		public string region { get; set; } = null;
		[JsonProperty("region_id")]
		public string regionId { get; set; } = null;
	}
}
