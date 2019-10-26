using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	class AdStudy : BaseModel
	{
		[JsonProperty("business")]
		public Business mBusiness { get; private set; } = null;
		[JsonProperty("canceled_time")]
		public string mCanceledTime { get; private set; } = null;
		[JsonProperty("cooldown_start_time")]
		public string mCooldownStartTime { get; private set; } = null;
		[JsonProperty("created_by")]
		public User mCreatedBy { get; private set; } = null;
		[JsonProperty("created_time")]
		public string mCreatedTime { get; private set; } = null;
		[JsonProperty("description")]
		public string mDescription { get; private set; } = null;
		[JsonProperty("end_time")]
		public string mEndTime { get; private set; } = null;
		[JsonProperty("id")]
		public string mId { get; private set; } = null;
		[JsonProperty("name")]
		public string mName { get; private set; } = null;
		[JsonProperty("observation_end_time")]
		public string mObservationEndTime { get; private set; } = null;
		[JsonProperty("results_first_available_date")]
		public string mResultsFirstAvailableDate { get; private set; } = null;
		[JsonProperty("start_time")]
		public string mStartTime { get; private set; } = null;
		[JsonProperty("type")]
		public string mType { get; private set; } = null;
		[JsonProperty("updated_by")]
		public User mUpdatedBy { get; private set; } = null;
		[JsonProperty("updated_time")]
		public string mUpdatedTime { get; private set; } = null;
	}
}
