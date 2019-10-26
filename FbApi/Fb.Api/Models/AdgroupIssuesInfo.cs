using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	class AdgroupIssuesInfo
	{
		[JsonProperty("error_code")]
		public long? errorCode = null;
		[JsonProperty("error_message")]
		public string errorMessage = null;
		[JsonProperty("error_summary")]
		public string errorSummary = null;
		[JsonProperty("error_type")]
		public string errorType = null;
		[JsonProperty("level")]
		public string level = null;
	}
}
