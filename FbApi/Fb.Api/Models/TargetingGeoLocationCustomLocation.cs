using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingGeoLocationCustomLocation
	{
		[JsonProperty("address_string")]
		public string addressstring { get; set; } = null;
		[JsonProperty("country")]
		public string country { get; set; } = null;
		[JsonProperty("country_group")]
		public string countryGroup { get; set; } = null;
		[JsonProperty("custom_type")]
		public string customType { get; set; } = null;
		[JsonProperty("distance_unit")]
		public string distanceUnit { get; set; } = null;
		[JsonProperty("key")]
		public string key { get; set; } = null;
		[JsonProperty("latitude")]
		public double? latitude { get; set; } = null;
		[JsonProperty("longitude")]
		public double? longitude { get; set; } = null;
		[JsonProperty("max_population")]
		public long? mxPopulation { get; set; } = null;
		[JsonProperty("min_population")]
		public long? minPopulation { get; set; } = null;
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
