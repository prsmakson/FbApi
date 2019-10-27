using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingGeoLocationPlace
	{
		[JsonProperty("country")]
		public string country { get; set; } = null;
		[JsonProperty("distance_unit")]
		public string distanceUnit { get; set; } = null;
		[JsonProperty("key")]
		public string key { get; set; } = null;
		[JsonProperty("latitude")]
		public double? latitude { get; set; } = null;
		[JsonProperty("longitude")]
		public double? longitude { get; set; } = null;
		[JsonProperty("name")]
		public string name { get; set; } = null;
		[JsonProperty("primary_city_id")]
		public long? primaryCityId { get; set; } = null;
		[JsonProperty("radius")]
		public double? radius { get; set; } = null;
		[JsonProperty("region_id")]
		public long? regionId { get; set; } = null;
	}
}
