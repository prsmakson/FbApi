using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativePhotoData
	{
		[JsonProperty("branded_content_shared_to_sponsor_status")]
		public string brandedContentSharedToSponsorStatus { get; private set; }  = null;
		[JsonProperty("branded_content_sponsor_page_id")]
		public string  brandedContentSponsorPageId { get; private set; } = null;
		[JsonProperty("caption")]
		public string caption { get; private set; } = null;
		[JsonProperty("image_hash")]
		public string imageHash { get; private set; } = null;
		[JsonProperty("page_welcome_message")]
		public string pageWelcomeMessage { get; private set; } = null;
		[JsonProperty("url")]
		public string url { get; private set; } = null;
	}
}
