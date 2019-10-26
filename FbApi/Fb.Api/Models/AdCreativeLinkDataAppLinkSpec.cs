using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeLinkDataAppLinkSpec
	{
		[JsonProperty("android")]
		public List<AndroidAppLink> android = null;
		[JsonProperty("ios")]
		public List<IosAppLink> ios = null;
		[JsonProperty("ipad")]
		public List<IosAppLink> ipad = null;
		[JsonProperty("iphone")]
		public List<IosAppLink> iphone = null;
	}
}
