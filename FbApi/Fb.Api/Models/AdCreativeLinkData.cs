using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeLinkData
	{
		[JsonProperty("additional_image_index")]
		public long? additionalImageIndex { get; private set; } = null;
		[JsonProperty("app_link_spec")]
		public AdCreativeLinkDataAppLinkSpec appLinkSpec { get; private set; } = null;
		[JsonProperty("attachment_style")]
		public ENUM_ATTACHEMENT_STYLE? attachmentStyle { get; private set; } = null;
		[JsonProperty("branded_content_shared_to_sponsor_status")]
		public string brandedContentSharedToSponsorStatus { get; private set; } = null;
		[JsonProperty("branded_content_sponsor_page_id")]
		public string brandedContentSponsorPageId { get; private set; } = null;
		[JsonProperty("call_to_action")]
		public AdCreativeLinkDataCallToAction callToAction { get; private set; } = null;
		[JsonProperty("caption")]
		public string caption { get; private set; } = null;
		[JsonProperty("child_attachments")]
		public IEnumerable<AdCreativeLinkDataChildAttachment> childAttachments { get; private set; } = null;
		[JsonProperty("collection_thumbnails")]
		public IEnumerable<AdCreativeCollectionThumbnailInfo> collectionThumbnails { get; private set; } = null;
		[JsonProperty("customization_rules_spec")]
		public IEnumerable<AdCustomizationRuleSpec> customizationRulesSpec { get; private set; } = null;
		[JsonProperty("description")]
		public string description { get; private set; } = null;
		[JsonProperty("event_id")]
		public string eventId { get; private set; } = null;
		[JsonProperty("force_single_link")]
		public bool? forceSingleLink { get; private set; } = null;
		[JsonProperty("format_option")]
		public ENUM_FORMAT_OPTION? formatOption { get; private set; } = null;
		[JsonProperty("image_crops")]
		public AdsImageCrops imageCrops { get; private set; } = null;
		[JsonProperty("image_hash")]
		public string mImageHash { get; private set; } = null;
		[JsonProperty("image_layer_specs")]
		public IEnumerable<AdCreativeLinkDataImageLayerSpec> imageLayerSpecs { get; private set; } = null;
		[JsonProperty("image_overlay_spec")]
		public AdCreativeLinkDataImageOverlaySpec imageOverlaySpec { get; private set; } = null;
		[JsonProperty("link")]
		public string mink { get; private set; } = null;
		[JsonProperty("message")]
		public string message { get; private set; } = null;
		[JsonProperty("multi_share_end_card")]
		public bool? multiShareEndCard { get; private set; } = null;
		[JsonProperty("multi_share_optimized")]
		public bool? multiShareOptimized { get; private set; } = null;
		[JsonProperty("offer_id")]
		public string offerId { get; private set; } = null;
		[JsonProperty("page_welcome_message")]
		public string pageWelcomeMessage { get; private set; } = null;
		[JsonProperty("picture")]
		public string picture { get; private set; } = null;
		[JsonProperty("post_click_configuration")]
		public AdCreativePostClickConfiguration postClickConfiguration { get; private set; } = null;
		[JsonProperty("preferred_image_tags")]

		public IEnumerable<string> preferredImageTags { get; private set; } = null;
		[JsonProperty("retailer_item_ids")]
		public IEnumerable<string> retailerItemIds { get; private set; } = null;
		[JsonProperty("show_multiple_images")]
		public bool? showMultipleImages { get; private set; } = null;
		[JsonProperty("static_fallback_spec")]
		public AdCreativeStaticFallbackSpec staticFallbackSpec { get; private set; } = null;
		[JsonProperty("use_flexible_image_aspect_ratio")]
		public bool? useFlexibleImageAspectRatio { get; private set; } = null;
		#region enums
		public enum ENUM_ATTACHEMENT_STYLE : int // проработать 
		{
			[JsonProperty("default")]
			Default,
			link


		}
		public enum ENUM_FORMAT_OPTION
		{
			carousel_images_multi_items,
			carousel_images_single_item,
			carousel_slideshows,
			single_image


		}
		#endregion
	}
}
