using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCampaignIssuesInfo
	{
		[JsonProperty("error_code")]
		public long? mErrorCode { get; private set; } = null;
		[JsonProperty("error_message")]
		public string mErrorMessage { get; private set; } = null;
		[JsonProperty("error_summary")]
		public string mErrorSummary { get; private set; } = null;
		[JsonProperty("error_type")]
		public string mErrorType { get; private set; } = null;
		[JsonProperty("level")]
		public string mLevel { get; private set; } = null;
	}
}
