using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
    public  abstract class BaseModel
    {
        public string name { get; set; }
        public string id { get; set; }
    }
}
