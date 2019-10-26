using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeTemplateURLSpec
	{
		[JsonProperty("android")]
		public object android { get; private set; } = null;
		[JsonProperty("config")]
		public object config { get; private set; } = null;
		[JsonProperty("ios")]
		public object ios { get; private set; } = null;
		[JsonProperty("ipad")]
		public object ipad { get; private set; } = null;
		[JsonProperty("iphone")]
		public object iphone { get; private set; } = null;
		[JsonProperty("web")]
		public object web { get; private set; } = null;
		[JsonProperty("windows_phone")]
		public object windowsPhone { get; private set; } = null;
	}
}
