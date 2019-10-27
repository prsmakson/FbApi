using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingGeoLocationLocationExpansion
	{
		[JsonProperty("allowed")]
		public bool? allowed { get; set; } = null;
	}
}
