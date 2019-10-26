using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdRecommendationData
	{
		[JsonProperty("link")]
		public string link { get; private set; } = null;
	}
}
