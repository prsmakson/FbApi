using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
    public class BaseAdAccount : BaseBusiness, IAdAccount
    {
        public AdAccount adAccount { get; private set; }

        public void SetAdAccount(AdAccount adAccount)
        {
            this.adAccount = adAccount;
        }
    }
}
