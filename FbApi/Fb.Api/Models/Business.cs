using Fb.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Fb.Api.Models
{
    public class Business : BaseModel
    {
        public IEnumerable<AdAccount> adAccounts { get; private set; } = new List<AdAccount>();
        public IEnumerable<Page> pages { get; private set; } = new List<Page>();
        public IEnumerable<Pixel> pixels { get; private set; } = new List<Pixel>();
        public Account account { get; private set; }
        #region GetFunctions
        public IEnumerable<AdAccount> GetAdAccounts()
        {
            string request = account.baseUri + id + "?fields=owned_ad_accounts{name,account_id,account_status}&access_token=" + account.getToken();
            adAccounts = ParseJsonResponseHelper.ParseAdAccount(RequestHelper.SendGetRequest(request, account.getSettings));
            SetBusinessForAdAccount();
            return adAccounts;
        }
        public IEnumerable<Page> GetPages()
        {
            string request = account.baseUri + id + "?fields=owned_pages{name,id,access_token}&access_token=" + account.getToken();
            pages = ParseJsonResponseHelper.ParsePages(RequestHelper.SendGetRequest(request, account.getSettings));
            SetBusinessForPages();
            return pages;
        }
        public IEnumerable<Pixel> GetPixels()
        {
            string request = account.baseUri + id + "?fields=owned_pixels{name,id}&access_token=" + account.getToken();
            pixels = ParseJsonResponseHelper.ParsePixels(RequestHelper.SendGetRequest(request, account.getSettings));
            SetBusinessForPiexels();
            return pixels;
        }
        #endregion
        public void SetBusinessAccount(Account account)
        {
            this.account = account;
        }
        private void SetBusinessForAdAccount()
        {
            foreach (var acc in adAccounts)
                acc.SetBusiness(this);
        }
        private void SetBusinessForPages()
        {
            foreach (var page in pages)
                page.SetBusiness(this);
        }
        private void SetBusinessForPiexels()
        {
            foreach (var pixel in pixels)
                pixel.SetBusiness(this);
        }

    }
}
