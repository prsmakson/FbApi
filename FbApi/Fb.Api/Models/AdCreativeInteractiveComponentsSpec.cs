using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeInteractiveComponentsSpec
	{
		[JsonProperty("components")]
		public IEnumerable<object> mComponents { get; private set; } = null;
	}
}
