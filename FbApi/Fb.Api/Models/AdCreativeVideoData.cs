using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeVideoData
	{
		[JsonProperty("additional_image_index")]
		public long? additionalImageIndex { get; private set; } = null;
		[JsonProperty("branded_content_shared_to_sponsor_status")]
		public string brandedContentSharedToSponsorStatus { get; private set; } = null;
		[JsonProperty("branded_content_sponsor_page_id")]
		public string brandedContentSponsorPageId { get; private set; } = null;
		[JsonProperty("call_to_action")]
		public AdCreativeLinkDataCallToAction callToAction { get; private set; } = null;
		[JsonProperty("collection_thumbnails")]
		public IEnumerable<AdCreativeCollectionThumbnailInfo> collectionThumbnails { get; private set; } = null;
		[JsonProperty("image_hash")]
		public string imageHash { get; private set; } = null;
		[JsonProperty("image_url")]
		public string imageUrl { get; private set; } = null;
		[JsonProperty("link_description")]
		public string linkDescription { get; private set; } = null;
		[JsonProperty("message")]
		public string message { get; private set; } = null;
		[JsonProperty("offer_id")]
		public string offerId { get; private set; } = null;
		[JsonProperty("page_welcome_message")]
		public string pageWelcomeMessage { get; private set; } = null;
		[JsonProperty("post_click_configuration")]
		public AdCreativePostClickConfiguration postClickConfiguration { get; private set; } = null;
		[JsonProperty("retailer_item_ids")]
		public IEnumerable<string> retailerItemIds { get; private set; } = null;
		[JsonProperty("targeting")]
		public Targeting trgeting { get; private set; } = null;
		[JsonProperty("title")]
		public string title { get; private set; } = null;
		[JsonProperty("video_id")]
		public string videoId { get; private set; } = null;
	}
}
