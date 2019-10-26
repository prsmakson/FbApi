using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeTextData
	{
		[JsonProperty("message")]
		public string message { get; private set; } = null;
	}
}
