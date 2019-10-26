using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeLinkDataCallToAction
	{
		[JsonProperty("type")]
		public ENUM_TYPE? mType { get; private set; } = null;
		[JsonProperty("value")]
		public AdCreativeLinkDataCallToActionValue value { get; private set; } = null;
		#region enums
		public enum ENUM_TYPE: int
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

			WOODHENGE_SUPPORT,

		}
		#endregion

	}
}
