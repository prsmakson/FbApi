using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdgroupReviewFeedback
	{
		[JsonProperty("global")]
		public Dictionary<string, string> global { get; private set; } = null;
		[JsonProperty("placement_specific")]
		public AdgroupPlacementSpecificReviewFeedback placementSpecific { get; private set; } = null;
	}
}
