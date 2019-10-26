using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdAssetFeedSpecVideo
	{
		[JsonProperty("adlabels")]
		public IEnumerable<AdAssetFeedSpecAssetLabel> adlabels { get; private set; } = null;
		[JsonProperty("caption_ids")]
		public IEnumerable<string> captionIds { get; private set; } = null;
		[JsonProperty("thumbnail_hash")]
		public string thumbnailHash { get; private set; } = null;
		[JsonProperty("thumbnail_url")]
		public string thumbnailUrl { get; private set; } = null;
		[JsonProperty("url_tags")]
		public string urlTags { get; private set; } = null;
		[JsonProperty("video_id")]
		public string videoId { get; private set; } = null;
	}
}
