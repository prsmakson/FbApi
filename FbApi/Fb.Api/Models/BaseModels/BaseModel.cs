using System;
using System.Collections.Generic;
using System.Text;
using Fb.Api.Models.Intf;
namespace Fb.Api.Models
{
    public abstract class BaseModel : IReferences
    {
        public string name { get; set; }
        public string id { get; set; }

        public virtual void LoadReferencesObject() { }
    }
}
