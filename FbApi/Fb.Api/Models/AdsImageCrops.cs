using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Fb.Api.Models
{
	public class AdsImageCrops
	{
		[JsonProperty("100x100")]
		public List<JArray> m100x100 { get; private set;  } = null;
		[JsonProperty("100x72")]
		public List<JArray> m100x72 { get; private set;  } = null;
		[JsonProperty("191x100")]
		public List<JArray> m191x100 { get; private set;  } = null;
		[JsonProperty("400x150")]
		public List<JArray> m400x150 { get; private set;  } = null;
		[JsonProperty("400x500")]
		public List<JArray> m400x500 { get; private set;  } = null;
		[JsonProperty("600x360")]
		public List<JArray> m600x360 { get; private set;  } = null;
		[JsonProperty("90x160")]
		public List<JArray> m90x160 { get; private set;  } = null;
	}
}
