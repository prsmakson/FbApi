using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Fb.Api.Models.Intf;
using Newtonsoft.Json;

namespace Fb.Api.Models
{
    public abstract class BaseModel : IReferences
    {
        [JsonProperty("name")]
        public virtual string name { get; private set; } = null;
		[JsonProperty("id")]
        public  virtual string id { get; private set; } = null;

		public virtual void LoadReferencesObject() { }
    }
}
