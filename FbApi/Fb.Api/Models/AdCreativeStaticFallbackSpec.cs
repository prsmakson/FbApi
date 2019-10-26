using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeStaticFallbackSpec
	{
		[JsonProperty("call_to_action")]
		public AdCreativeLinkDataCallToAction callToAction { get; private set; } = null;
		[JsonProperty("description")]
		public string description { get; private set; } = null;
		[JsonProperty("image_hash")]
		public string imageHash { get; private set; } = null;
		[JsonProperty("link")]
		public string link { get; private set; } = null;
		[JsonProperty("message")]
		public string message { get; private set; } = null;
		[JsonProperty("name")]
		public string name { get; private set; } = null;
	}
}
