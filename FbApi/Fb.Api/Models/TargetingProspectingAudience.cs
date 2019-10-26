using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingProspectingAudience
	{
		[JsonProperty("sources")]
		public List<object> mSources { get; private set; } = null;
	}
}
