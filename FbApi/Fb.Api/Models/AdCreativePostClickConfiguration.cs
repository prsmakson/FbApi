using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativePostClickConfiguration
	{
		[JsonProperty("post_click_item_description")]
		public string postClickItemDescription { get; private set; } = null;
		[JsonProperty("post_click_item_headline")]
		public string postClickItemHeadline { get; private set; } = null;
	}
}
