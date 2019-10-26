using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class CatalogBasedTargeting
	{
		[JsonProperty("geo_targeting_type")]
	public string mGeoTargetingType { get; private set; } = null;
	}
}
