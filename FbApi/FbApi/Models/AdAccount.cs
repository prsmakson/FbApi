using System;
using System.Collections.Generic;
using System.Text;

namespace FbApi.Models
{
    class AdAccount:BaseModel
    {
        public ACCOUNT_STATUS account_status { get; set; }
    }
    public enum ACCOUNT_STATUS: int
    {
        ACTIVE=1,
        DISABLED=2,
        UNSETTLED=3,
        PENDING_RISK_REVIEW=7,
        PENDING_SETTLEMENT=8,
        IN_GRACE_PERIOD=9,
        PENDING_CLOSURE=100,
        CLOSED=101,
        ANY_ACTIVE=201,
        ANY_CLOSED=202
    }
}
