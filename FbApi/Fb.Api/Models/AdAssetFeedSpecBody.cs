using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdAssetFeedSpecBody
	{
		[JsonProperty("adlabels")]
		public IEnumerable<AdAssetFeedSpecAssetLabel> adlabels { get; private set; } = null;
		[JsonProperty("text")]
		public string text { get; private set; } = null;
		[JsonProperty("url_tags")]
		public string urlTags { get; private set; } = null;
	}
}
