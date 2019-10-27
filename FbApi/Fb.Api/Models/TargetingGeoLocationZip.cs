using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingGeoLocationZip
	{
		[JsonProperty("country")]
		public string country { get; set; } = null;
		[JsonProperty("key")]
		public string key { get; set; } = null;
		[JsonProperty("name")]
		public string name { get; set; } = null;
		[JsonProperty("primary_city_id")]
		public long? primaryCityId { get; set; } = null;
		[JsonProperty("region_id")]
		public long? regionId { get; set; } = null;
	}
}
