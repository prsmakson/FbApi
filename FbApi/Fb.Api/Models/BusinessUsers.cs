using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
    class BusinessUsers : BaseModel
    {
        public IEnumerable<AdAccount> adAccounts { get; private set; }

        public IEnumerable<Pixel> pixels { get; private set; }
        public IEnumerable<Page> pages { get; private set; }
        public IEnumerable<InstagrammAccount> instagrammAccounts { get; private set; }

    }
}
