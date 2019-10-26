using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class IDName
	{
		[JsonProperty("id")]
		public string id= null;
		[JsonProperty("name")]
		public string name = null;
	}
}
