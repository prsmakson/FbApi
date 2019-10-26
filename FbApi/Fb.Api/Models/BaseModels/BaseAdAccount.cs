using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
    public class BaseAdAccount : BaseBusiness, IAdAccount
    {
		[JsonProperty("account_id")]
		public string accountId { get; private set; } = null;
		public AdAccount adAccount { get; private set; }

        public void SetAdAccount(AdAccount adAccount)
        {
            this.adAccount = adAccount;
        }
    }
}
