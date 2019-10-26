using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class ConversionActionQuery
	{
		[JsonProperty("action.type")]
		public IEnumerable<object> actionType { get; private set; } = null;
		[JsonProperty("application")]
		public IEnumerable<object> application { get; private set; } = null;
		[JsonProperty("conversion_id")]
		public IEnumerable<string> conversionId { get; private set; } = null;
		[JsonProperty("creative")]
		public IEnumerable<object> creative { get; private set; } = null;
		[JsonProperty("dataset")]
		public IEnumerable<string> dataset { get; private set; } = null;
		[JsonProperty("event")]
		public IEnumerable<string> Event { get; private set; } = null;
		[JsonProperty("event.creator")]
		public IEnumerable<string> eventCreator { get; private set; } = null;
		[JsonProperty("event_type")]
		public IEnumerable<string> eventType { get; private set; } = null;
		[JsonProperty("fb_pixel")]
		public IEnumerable<string> fbPixel { get; private set; } = null;
		[JsonProperty("fb_pixel_event")]
		public IEnumerable<string> fbPixelEvent { get; private set; } = null;
		[JsonProperty("leadgen")]
		public IEnumerable<string> leadgen { get; private set; } = null;
		[JsonProperty("object")]
		public IEnumerable<string> Object { get; private set; } = null;
		[JsonProperty("object.domain")]
		public IEnumerable<string> objectDomain { get; private set; } = null;
		[JsonProperty("offer")]
		public IEnumerable<string> offer { get; private set; } = null;
		[JsonProperty("offer.creator")]
		public IEnumerable<string> offerCreator { get; private set; } = null;
		[JsonProperty("offsite_pixel")]
		public IEnumerable<string> offsitePixel { get; private set; } = null;
		[JsonProperty("page")]
		public IEnumerable<string> page { get; private set; } = null;
		[JsonProperty("page.parent")]
		public IEnumerable<string> pageParent { get; private set; } = null;
		[JsonProperty("post")]
		public IEnumerable<string> post { get; private set; } = null;
		[JsonProperty("post.object")]
		public IEnumerable<string> postobject { get; private set; } = null;
		[JsonProperty("post.object.wall")]
		public IEnumerable<string> postobjectWall { get; private set; } = null;
		[JsonProperty("post.wall")]
		public IEnumerable<string> postWall { get; private set; } = null;
		[JsonProperty("question")]
		public IEnumerable<string> question { get; private set; } = null;
		[JsonProperty("question.creator")]
		public IEnumerable<string> questionCreator { get; private set; } = null;
		[JsonProperty("response")]
		public IEnumerable<string> response { get; private set; } = null;
		[JsonProperty("subtype")]
		public IEnumerable<string> subtype { get; private set; } = null;
	}
}
