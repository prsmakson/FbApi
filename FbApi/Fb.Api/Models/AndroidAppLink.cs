using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AndroidAppLink
	{
		[JsonProperty("app_name")]
		public string appName { get; private set; } = null;
		[JsonProperty("class")]
		public string Class { get; private set; } = null;
		[JsonProperty("package")]
		public string package { get; private set; } = null;
		[JsonProperty("url")]
		public string url { get; private set; } = null;
	}
}
