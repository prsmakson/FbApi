using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api
{
	public class RawCustomAudience
	{
		[JsonProperty("id")]
		public string mId { get; private set; } = null;
		[JsonProperty("name")]
		public string mName { get; private set; } = null;
	}
}
