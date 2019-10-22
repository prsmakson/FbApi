using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
    public class AdSet : BaseModel
    {
        public string id { get; set; }
        public double lifetime_budget { get; set; }
        public string namebudget { get; set; }
    }
}
