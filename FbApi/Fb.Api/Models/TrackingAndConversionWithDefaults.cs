using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	class TrackingAndConversionWithDefaults
	{
		[JsonProperty("custom_conversion")]
		public IEnumerable<object> customConversion { get; private set; } = null;
		[JsonProperty("custom_tracking")]
		public IEnumerable<object> customTracking { get; private set; } = null;
		[JsonProperty("default_conversion")]
		public IEnumerable<object> defaultConversion { get; private set; } = null;
		[JsonProperty("default_tracking")]
		public IEnumerable<object> defaultTracking { get; private set; } = null;
	}
}
