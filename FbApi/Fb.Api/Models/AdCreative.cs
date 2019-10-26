using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreative : BaseAdAccount
	{
		[JsonProperty("actor_id")]
		public string actorId { get; private set; } = null;
		[JsonProperty("adlabels")]
		public List<AdLabel> adlabels { get; private set; } = null;
		[JsonProperty("applink_treatment")]
		public ENUM_APP_LINK_TREATMENT? applinkTreatment { get; private set; } = null;
		[JsonProperty("asset_feed_spec")]
		public AdAssetFeedSpec assetFeedSpec { get; private set; } = null;
		[JsonProperty("authorization_category")]
		public string authorizationCategory { get; private set; } = null;
		[JsonProperty("auto_update")]
		public bool? autoUpdate { get; private set; } = null;
		[JsonProperty("body")]
		public string body { get; private set; } = null;
		[JsonProperty("branded_content_sponsor_page_id")]
		public string brandedContentSponsorPageId { get; private set; } = null;
		[JsonProperty("bundle_folder_id")]
		public string bundleFolderId { get; private set; } = null;
		[JsonProperty("call_to_action_type")]
		public ENUM_CALL_TO_ACTION_TYPE? callToActionType { get; private set; } = null;
		[JsonProperty("categorization_criteria")]
		public string categorizationCriteria { get; private set; } = null;
		[JsonProperty("category_media_source")]
		public string categoryMediaSource { get; private set; } = null;
		[JsonProperty("destination_set_id")]
		public string destinationSetId { get; private set; } = null;
		[JsonProperty("dynamic_ad_voice")]
		public string dynamicAdVoice { get; private set; } = null;
		[JsonProperty("effective_authorization_category")]
		public string effectiveAuthorizationCategory { get; private set; } = null;
		[JsonProperty("effective_instagram_media_id")]
		public string effectiveInstagramMediaId { get; private set; } = null;
		[JsonProperty("effective_instagram_story_id")]
		public string effectiveInstagramStoryId { get; private set; } = null;
		[JsonProperty("effective_object_story_id")]
		public string effectiveObjectStoryId { get; private set; } = null;
		[JsonProperty("enable_direct_install")]
		public bool? enableDirectInstall { get; private set; } = null;
		[JsonProperty("enable_launch_instant_app")]
		public bool? enableLaunchInstantApp { get; private set; } = null;
		[JsonProperty("image_crops")]
		public AdsImageCrops imageCrops { get; private set; } = null;
		[JsonProperty("image_hash")]
		public string imageHash { get; private set; } = null;
		[JsonProperty("image_url")]
		public string imageUrl { get; private set; } = null;
		[JsonProperty("instagram_actor_id")]
		public string instagramActorId { get; private set; } = null;
		[JsonProperty("instagram_permalink_url")]
		public string instagramPermalinkUrl { get; private set; } = null;
		[JsonProperty("instagram_story_id")]
		public string instagramStoryId { get; private set; } = null;
		[JsonProperty("interactive_components_spec")]
		public AdCreativeInteractiveComponentsSpec mInteractiveComponentsSpec { get; private set; } = null;
		[JsonProperty("link_deep_link_url")]
		public string linkDeepLinkUrl { get; private set; } = null;
		[JsonProperty("link_og_id")]
		public string linkOgId { get; private set; } = null;
		[JsonProperty("link_url")]
		public string linkUrl { get; private set; } = null;
		[JsonProperty("messenger_sponsored_message")]
		public string messengerSponsoredMessage { get; private set; } = null;
		[JsonProperty("object_id")]
		public string objectId { get; private set; } = null;
		[JsonProperty("object_store_url")]
		public string objectStoreUrl { get; private set; } = null;
		[JsonProperty("object_story_id")]
		public string objectStoryId { get; private set; } = null;
		[JsonProperty("object_story_spec")]
		public AdCreativeObjectStorySpec objectStorySpec { get; private set; } = null;
		[JsonProperty("object_type")]
		public ENUM_OBJECT_TYPE? objectType { get; private set; } = null;
		[JsonProperty("object_url")]
		public string objectUrl { get; private set; } = null;
		[JsonProperty("place_page_set_id")]
		public string placePageSetId { get; private set; } = null;
		[JsonProperty("platform_customizations")]
		public AdCreativePlatformCustomization platformCustomizations { get; private set; } = null;
		[JsonProperty("playable_asset_id")]
		public string playableAssetId { get; private set; } = null;
		[JsonProperty("portrait_customizations")]
		public AdCreativePortraitCustomizations portraitCustomizations { get; private set; } = null;
		[JsonProperty("product_set_id")]
		public string productSetId { get; private set; } = null;
		[JsonProperty("recommender_settings")]
		public AdCreativeRecommenderSettings recommenderSettings { get; private set; } = null;
		[JsonProperty("status")]
		public ENUM_STATUS? mStatus { get; private set; } = null;
		[JsonProperty("template_url")]
		public string templateUrl { get; private set; } = null;
		[JsonProperty("template_url_spec")]
		public AdCreativeTemplateURLSpec templateUrlSpec { get; private set; } = null;
		[JsonProperty("thumbnail_url")]
		public string thumbnailUrl { get; private set; } = null;
		[JsonProperty("title")]
		public string title { get; private set; } = null;
		[JsonProperty("url_tags")]
		public string urlTags { get; private set; } = null;
		[JsonProperty("use_page_actor_override")]
		public bool? usePageActorOverride { get; private set; } = null;
		[JsonProperty("video_id")]
		public string videoId { get; private set; } = null;
		[JsonProperty("creative_id")]
		public string creativeId { get; private set; } = null;
		#region enums
		public enum ENUM_STATUS : int
		{
			ACTIVE,
			DELETED,
			IN_PROCESS,
			WITH_ISSUES


		}
		public enum ENUM_OBJECT_TYPE : int
		{
			APPLICATION,
			DOMAIN,
			EVENT,
			INVALID,
			OFFER,
			PAGE,
			PHOTO,
			SHARE,
			STATUS,
			STORE_ITEM,
			VIDEO,


		}
		public enum ENUM_APP_LINK_TREATMENT : int
		{
			deeplink_with_appstore_fallback,
			deeplink_with_web_fallback,
			web_only


		}
		public enum ENUM_CALL_TO_ACTION_TYPE : int
		{
			ADD_TO_CART,
			APPLY_NOW,
			BOOK_TRAVEL,
			BUY,
			BUY_NOW,
			BUY_TICKETS,
			CALL,
			CALL_ME,
			CONTACT,
			CONTACT_US,
			DONATE,
			DONATE_NOW,
			DOWNLOAD,
			EVENT_RSVP,
			FIND_A_GROUP,
			FIND_YOUR_GROUPS,
			FOLLOW_NEWS_STORYLINE,
			GET_DIRECTIONS,
			GET_OFFER,
			GET_OFFER_VIEW,
			GET_QUOTE,
			GET_SHOWTIMES,
			INSTALL_APP,
			INSTALL_MOBILE_APP,
			LEARN_MORE,
			LIKE_PAGE,
			LISTEN_MUSIC,
			LISTEN_NOW,
			MESSAGE_PAGE,
			MOBILE_DOWNLOAD,
			MOMENTS,
			NO_BUTTON,
			OPEN_LINK,
			ORDER_NOW,
			PLAY_GAME,
			RECORD_NOW,
			SAY_THANKS,
			SEE_MORE,
			SELL_NOW,
			SHARE,
			SHOP_NOW,
			SIGN_UP,
			SOTTO_SUBSCRIBE,
			SUBSCRIBE,
			UPDATE_APP,
			USE_APP,
			USE_MOBILE_APP,
			VIDEO_ANNOTATION,
			VISIT_PAGES_FEED,
			WATCH_MORE,
			WATCH_VIDEO,
			WHATSAPP_MESSAGE,
			WOODHENGE_SUPPORT
		}
		#endregion
	}
}
