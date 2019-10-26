using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativePlaceData
	{
		[JsonProperty("address_string")]
		private string addressstring = null;
		[JsonProperty("label")]
		private string label = null;
		[JsonProperty("latitude")]
		private double? latitude = null;
		[JsonProperty("location_source_id")]
		private string locationSourceId = null;
		[JsonProperty("longitude")]
		private double? longitude = null;
		[JsonProperty("type")]
		private string type = null;
	}
}
