using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
    public class BaseBusiness : BaseModel,IBusiness
    {
        public Business business { get; private set; }

        public void SetBusiness(Business business)
        {
            this.business = business;
        }
    }
}
