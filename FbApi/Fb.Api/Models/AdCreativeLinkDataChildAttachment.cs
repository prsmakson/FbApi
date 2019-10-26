using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeLinkDataChildAttachment
	{
		[JsonProperty("call_to_action")]
		public AdCreativeLinkDataCallToAction callToAction { get; private set; } = null;
		[JsonProperty("caption")]
		public string caption { get; private set; } = null;
		[JsonProperty("description")]
		public string description { get; private set; } = null;
		[JsonProperty("image_crops")]
		public AdsImageCrops imageCrops { get; private set; } = null;
		[JsonProperty("image_hash")]
		public string imageHash { get; private set; } = null;
		[JsonProperty("link")]
		public string link { get; private set; } = null;
		[JsonProperty("name")]
		public string name { get; private set; } = null;
		[JsonProperty("picture")]
		public string picture { get; private set; } = null;
		[JsonProperty("place_data")]
		public AdCreativePlaceData placeData { get; private set; } = null;
		[JsonProperty("static_card")]
		public bool? staticCard { get; private set; } = null;
		[JsonProperty("video_id")]
		public string videoId { get; private set; } = null;
	}
}
