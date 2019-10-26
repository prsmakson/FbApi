using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdRecommendation
	{
		[JsonProperty("blame_field")]
		public string blameField { get; private set; }= null;
		[JsonProperty("code")]
		public long? code { get; private set; }= null;
		[JsonProperty("confidence")]
		public ENUM_CONFIDENCE? mConfidence { get; private set; }= null;
		[JsonProperty("importance")]
		public ENUM_IMPORTANCE? importance  { get; private set; }= null;
		[JsonProperty("message")]
		public string message { get; private set; }= null;
		[JsonProperty("recommendation_data")]
		public AdRecommendationData recommendationData { get; private set; }= null;
		[JsonProperty("title")]
		public string mTitle { get; private set; }= null;
		public enum ENUM_CONFIDENCE : int
		{
			HIGH,
			LOW,
			MEDIUM
		}
		public enum ENUM_IMPORTANCE : int
		{
			HIGH,
			LOW,
			MEDIUM


		}
	}
}
