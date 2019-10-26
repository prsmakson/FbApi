using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeLinkDataCallToActionValue
	{
		[JsonProperty("app_destination")]
		public string appDestination = null;
		[JsonProperty("app_link")]
		public string appLink = null;
		[JsonProperty("application")]
		public string application = null;
		[JsonProperty("event_id")]
		public string eventId = null;
		[JsonProperty("lead_gen_form_id")]
		public string leadGenFormId = null;
		[JsonProperty("link")]
		public string link = null;
		[JsonProperty("link_caption")]
		public string linkCaption = null;
		[JsonProperty("link_format")]
		public string linkFormat = null;
		[JsonProperty("page")]
		public string page = null;
		[JsonProperty("product_link")]
		public string productLink = null;
		[JsonProperty("whatsapp_number")]
		public string whatsappNumber = null;
	}
}
