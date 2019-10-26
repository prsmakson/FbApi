using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativePortraitCustomizations
	{
		[JsonProperty("specifications")]
		public IEnumerable<object> specifications { get; private set; } = null;
	}
}
