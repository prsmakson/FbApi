using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeRecommenderSettings
	{
		[JsonProperty("preferred_events")]
		public IEnumerable<string> preferredEvents { get; private set; } = null;
		[JsonProperty("product_sales_channel")]
		public string productSalesChannel { get; private set; } = null;
	}
}
