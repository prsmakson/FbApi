using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeObjectStorySpec
	{
		[JsonProperty("instagram_actor_id")]
		public string instagramActorId { get; private set; }= null;
		[JsonProperty("link_data")]
		public AdCreativeLinkData linkData { get; private set; }= null;
		[JsonProperty("page_id")]
		public string pageId { get; private set; }= null;
		[JsonProperty("photo_data")]
		public AdCreativePhotoData photoData { get; private set; }= null;
		[JsonProperty("template_data")]
		public AdCreativeLinkData templateData { get; private set; }= null;
		[JsonProperty("text_data")]
		public AdCreativeTextData textData { get; private set; }= null;
		[JsonProperty("video_data")]
		public AdCreativeVideoData videoData { get; private set; }= null;
	}
}
