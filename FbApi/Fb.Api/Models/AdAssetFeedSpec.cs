using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdAssetFeedSpec
	{
		[JsonProperty("ad_formats")]
		public List<string> adFormats = null;
		[JsonProperty("additional_data")]
		public object additionalData = null;
		[JsonProperty("asset_customization_rules")]
		public List<object> assetCustomizationRules = null;
		[JsonProperty("autotranslate")]
		public List<string> autotranslate = null;
		[JsonProperty("bodies")]
		public List<AdAssetFeedSpecBody> bodies = null;
		[JsonProperty("call_to_action_types")]
		public List<ENUM_CALL_TO_ACTION_TYPES> callToActionTypes = null;
		[JsonProperty("captions")]
		public List<AdAssetFeedSpecCaption> captions = null;
		[JsonProperty("descriptions")]
		public List<AdAssetFeedSpecDescription> descriptions = null;
		[JsonProperty("groups")]
		public List<AdAssetFeedSpecGroupRule> groups = null;
		[JsonProperty("images")]
		public List<AdAssetFeedSpecImage> images = null;
		[JsonProperty("link_urls")]
		public List<AdAssetFeedSpecLinkURL> linkUrls = null;
		[JsonProperty("optimization_type")]
		public string optimizationType = null;
		[JsonProperty("titles")]
		public List<AdAssetFeedSpecTitle> titles = null;
		[JsonProperty("videos")]
		public List<AdAssetFeedSpecVideo> videos = null;

		public enum ENUM_CALL_TO_ACTION_TYPES : int
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
	}
}
