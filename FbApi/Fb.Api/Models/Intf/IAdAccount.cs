﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
    public interface IAdAccount
    {
		
		public string accountId { get;  } 
		public AdAccount adAccount { get;  }
		public void SetAdAccount(AdAccount adAccount);
    }
}
