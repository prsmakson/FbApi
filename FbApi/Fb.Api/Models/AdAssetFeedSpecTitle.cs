using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdAssetFeedSpecTitle
	{
		[JsonProperty("adlabels")]
		public List<AdAssetFeedSpecAssetLabel> adlabels { get; set; } = null;
		[JsonProperty("text")]
		public string text { get; set; } = null;
		[JsonProperty("url_tags")]
		public string urlTags { get; set; } = null;
	}
}
