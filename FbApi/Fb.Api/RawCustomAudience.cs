using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api
{
	public class RawCustomAudience
	{
		[JsonProperty("id")]
		public string id { get; private set; } = null;
		[JsonProperty("name")]
		public string name { get; private set; } = null;
	}
}
