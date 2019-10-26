using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativePlatformCustomization
	{
		[JsonProperty("instagram")]
		public object instagram { get; private set; } = null;
	}
}
