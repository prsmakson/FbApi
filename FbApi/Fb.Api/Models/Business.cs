using Fb.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Fb.Api.Models.Exstension;
namespace Fb.Api.Models
{
    public class Business : BaseModel
    {
        [Display(Name = "can_create_ad_account")]
        public bool canCreateAdAccount { get; private set; }
        [Display(Name = "can_add_or_create_page")]
        public bool canAddOrCreatePage { get; private set; }
        [Display(Name = "allow_page_management_in_www")]
        public bool allowPageManagementInWWW { get; private set; }
        [Display(Name = "block_offline_analytics")]
        public bool blockOfflineAnalytics { get; private set; }
        [Display(Name = "created_time")]
        public DateTime createdTime { get; private set; }
        [Display(Name = "is_hidden")]
        public bool isHidden { get; private set; }
        [Display(Name = "link")]
        public string link { get; private set; }
        [Display(Name = "timezone_id")]
        public int timezoneId { get; private set; }
        [Display(Name = "profile_picture_uri")]
        public string profilePictureUri { get; private set; }
        [Display(Name = "is_disabled_for_integrity_reasons")]
        public string isDisabledForIntegrityReasons { get; private set; }
        #region ParamNotEntity
        public IEnumerable<AdAccount> adAccounts { get; private set; } = new List<AdAccount>();
        public IEnumerable<Page> pages { get; private set; } = new List<Page>();
        public IEnumerable<Pixel> pixels { get; private set; } = new List<Pixel>();
        public Account account { get; private set; }
        #endregion
        #region GetFunctions
        public IEnumerable<AdAccount> GetAdAccounts()
        {
            string request = account.baseUri + id + "?fields=owned_ad_accounts{"+typeof(AdAccount).GetRequestGetString()+"}&access_token=" + account.getToken();
            adAccounts = ParseJsonResponseHelper.ParseAdAccount(RequestHelper.SendGetRequest(request, account.getSettings));
            SetBusinessForAdAccount();
            return adAccounts;
        }
        private async Task<IEnumerable<AdAccount>> GetAdAccountsAsync()
        {
            return await Task.Run(() => GetAdAccounts());
        }
        public IEnumerable<Page> GetPages()
        {
            string request = account.baseUri + id + "?fields=owned_pages{"+ typeof(Page).GetRequestGetString() + "}&access_token=" + account.getToken();
            pages = ParseJsonResponseHelper.ParsePages(RequestHelper.SendGetRequest(request, account.getSettings));
            SetBusinessForPages();
            return pages;
        }
        private async Task<IEnumerable<Page>> GetPagesAsync()
        {
            return await Task.Run(() => GetPages());
        }
        public IEnumerable<Pixel> GetPixels()
        {
            string request = account.baseUri + id + "?fields=owned_pixels{"+typeof(Pixel).GetRequestGetString()+"}&access_token=" + account.getToken();
            pixels = ParseJsonResponseHelper.ParsePixels(RequestHelper.SendGetRequest(request, account.getSettings));
            SetBusinessForPiexels();
            return pixels;
        }
        private async Task<IEnumerable<Pixel>> GetPixelsAsync()
        {
            return await Task.Run(() => GetPixels());
        }
        public override void LoadReferencesObject()
        {
            var pagesA = GetPagesAsync();
            var adAccountsA = GetAdAccountsAsync();
            var pixelsA = GetPixelsAsync();
            pages = pagesA.Result;
            adAccounts = adAccountsA.Result;
            pixels = pixelsA.Result;

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

        #region staticFunction
        //public static Business GetBusiness(string id)
        //{

        //}
        #endregion

    }


}
