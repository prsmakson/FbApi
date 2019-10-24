using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Fb.Api.Models.Intf;
namespace Fb.Api.Models
{
    public abstract class BaseModel : IReferences
    {
        [Display(Name = "name")]
        public string name { get; set; }
        [Display(Name = "id")]
        public string id { get; set; }

        public virtual void LoadReferencesObject() { }
    }
}
