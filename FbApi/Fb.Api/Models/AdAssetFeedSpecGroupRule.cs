using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdAssetFeedSpecGroupRule
	{
		[JsonProperty("body_label")]
		public AdAssetFeedSpecAssetLabel bodyLabel { get; private set; } = null;
		[JsonProperty("caption_label")]
		public AdAssetFeedSpecAssetLabel captionLabel { get; private set; } = null;
		[JsonProperty("description_label")]
		public AdAssetFeedSpecAssetLabel descriptionLabel { get; private set; } = null;
		[JsonProperty("image_label")]
		public AdAssetFeedSpecAssetLabel imageLabel { get; private set; } = null;
		[JsonProperty("link_url_label")]
		public AdAssetFeedSpecAssetLabel linkUrlLabel { get; private set; } = null;
		[JsonProperty("title_label")]
		public AdAssetFeedSpecAssetLabel titleLabel { get; private set; } = null;
		[JsonProperty("video_label")]
		public AdAssetFeedSpecAssetLabel videoLabel { get; private set; } = null;
	}
}
