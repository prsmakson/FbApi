using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdPromotedObject
	{
		[JsonProperty("application_id")]
		public string applicationId { get; private set; } = null;
		[JsonProperty("custom_conversion_id")]
		public string customConversionId { get; private set; } = null;
		[JsonProperty("custom_event_str")]
		public string customEventStr { get; private set; } = null;
		[JsonProperty("custom_event_type")]
		public ENUM_CUSTOM_EVENT_TYPE? mCustomEventType { get; set; } = null;
		[JsonProperty("event_id")]
		public string eventId { get; private set; } = null;
		[JsonProperty("fundraiser_campaign_id")]
		public string fundraiserCampaignId { get; private set; } = null;
		[JsonProperty("object_store_url")]
		public string objectStoreUrl { get; private set; } = null;
		[JsonProperty("offer_id")]
		public string offerId { get; private set; } = null;
		[JsonProperty("offline_conversion_data_set_id")]
		public string offlineConversionDataSetId { get; private set; } = null;
		[JsonProperty("page_id")]
		public string pageId { get; private set; } = null;
		[JsonProperty("pixel_aggregation_rule")]
		public string pixelAggregationRule { get; private set; } = null;
		[JsonProperty("pixel_id")]
		public string pixelId { get; private set; } = null;
		[JsonProperty("pixel_rule")]
		public string pixelRule { get; private set; } = null;
		[JsonProperty("place_page_set_id")]
		public string placePageSetId { get; private set; } = null;
		[JsonProperty("product_catalog_id")]
		public string productCatalogId { get; private set; } = null;
		[JsonProperty("product_item_id")]
		public string mProductItemId { get; private set; } = null;
		[JsonProperty("product_set_id")]
		public string productSetId { get; private set; } = null;
		[JsonProperty("retention_days")]
		public string retentionDays { get; private set; } = null;
		public enum ENUM_CUSTOM_EVENT_TYPE : int
		{
			ACHIEVEMENT_UNLOCKED,
			ADD_PAYMENT_INFO,
			ADD_TO_CART,
			ADD_TO_WISHLIST,
			COMPLETE_REGISTRATION,
			CONTACT,
			CONTENT_VIEW,
			CUSTOMIZE_PRODUCT,
			D2_RETENTION,
			D7_RETENTION,
			DONATE,
			FIND_LOCATION,
			INITIATED_CHECKOUT,
			LEAD,
			LEVEL_ACHIEVED,
			LISTING_INTERACTION,
			MESSAGING_CONVERSATION_STARTED_7D,
			OTHER,
			PURCHASE,
			RATE,
			SCHEDULE,
			SEARCH,
			SERVICE_BOOKING_REQUEST,
			SPENT_CREDITS,
			START_TRIAL,
			SUBMIT_APPLICATION,
			SUBSCRIBE,
			TUTORIAL_COMPLETION,

		}
	}
}
