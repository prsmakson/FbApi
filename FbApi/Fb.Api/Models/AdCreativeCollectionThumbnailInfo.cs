using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeCollectionThumbnailInfo
	{
		[JsonProperty("element_child_index")]
		public long? mElementChildIndex { get; private set; } = null;
		[JsonProperty("element_crops")]
		public AdsImageCrops mElementCrops { get; private set; } = null;
		[JsonProperty("element_id")]
		public string mElementId { get; private set; } = null;
	}
}
