using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class IosAppLink
	{
		[JsonProperty("app_name")]
		public string appName { get; private set; } = null;
		[JsonProperty("app_store_id")]
		public string appStoreId { get; private set; } = null;
		[JsonProperty("url")]
		public string url { get; private set; } = null;
	}
}
