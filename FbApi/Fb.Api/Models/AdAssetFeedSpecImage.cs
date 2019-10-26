using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdAssetFeedSpecImage
	{
		[JsonProperty("adlabels")]
		public List<AdAssetFeedSpecAssetLabel> mAdlabels { get; private set;  } = null;
		[JsonProperty("hash")]
		public string mHash { get; private set;  } = null;
		[JsonProperty("image_crops")]
		public AdsImageCrops mImageCrops { get; private set;  } = null;
		[JsonProperty("url")]
		public string url { get; private set;  } = null;
		[JsonProperty("url_tags")]
		public string urlTags { get; private set;  } = null;
	}
}
