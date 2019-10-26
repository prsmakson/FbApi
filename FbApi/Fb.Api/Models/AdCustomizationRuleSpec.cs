using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCustomizationRuleSpec
	{
		[JsonProperty("caption")]
		public string caption { get; private set; } = null;
		[JsonProperty("customization_spec")]
		public Object customizationSpec { get; private set; } = null;
		[JsonProperty("description")]
		public string description { get; private set; } = null;
		[JsonProperty("link")]
		public string link { get; private set; } = null;
		[JsonProperty("message")]
		public string message { get; private set; } = null;
		[JsonProperty("name")]
		public string name { get; private set; } = null;
		[JsonProperty("priority")]
		public long? priority { get; private set; } = null;
		[JsonProperty("template_url_spec")]
		public AdCreativeTemplateURLSpec templateUrlSpec { get; private set; } = null;
	}
}
