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
        public string name { get; set; }
        [JsonProperty("id")]
        public string id { get; set; }

        public virtual void LoadReferencesObject() { }
    }
}
