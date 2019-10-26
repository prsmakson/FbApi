using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdAssetFeedSpecLinkURL
	{
		[JsonProperty("adlabels")]
		public List<AdAssetFeedSpecAssetLabel> adlabels { get; private set; } = null;
		[JsonProperty("carousel_see_more_url")]
		public string carouselSeeMoreUrl { get; private set; } = null;
		[JsonProperty("deeplink_url")]
		public string deeplinkUrl { get; private set; } = null;
		[JsonProperty("display_url")]
		public string displayUrl { get; private set; } = null;
		[JsonProperty("url_tags")]
		public string urlTags { get; private set; } = null;
		[JsonProperty("website_url")]
		public string websiteUrl { get; private set; } = null;
}
}
