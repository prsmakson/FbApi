using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class DeliveryCheck
	{
		[JsonProperty("check_name")]
		public string checkName { get; private set; } = null;
		[JsonProperty("description")]
		public string description { get; private set; } = null;
		[JsonProperty("extra_info")]
		public DeliveryCheckExtraInfo extraInfo { get; private set; } = null;
		[JsonProperty("summary")]
		public string summary { get; private set; } = null;
	}
}
