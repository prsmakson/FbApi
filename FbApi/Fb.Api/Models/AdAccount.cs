using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Fb.Api.Helpers;
namespace Fb.Api.Models
{
    public class AdAccount : BaseBusiness
    {
        [Display(Name = "account_status")]
        public ACCOUNT_STATUS accountStatus { get; private set; }
        [Display(Name = "age")]
        public double age { get; set; }
        [Display(Name = "amount_spent")]
        public string amountSpent { get; private set; }
        [Display(Name = "balance")]
        public string balance { get; private set; }
        [Display(Name = "business_city")]
        public string businessCity { get; private set; }
        [Display(Name = "business_country_code")]
        public string businessCountryCode { get; private set; }
        [Display(Name = "capabilities")]
        public IEnumerable<string> capabilities { get; private set; }
        [Display(Name = "created_time")]
        public DateTime createdTime { get; private set; }
        [Display(Name = "currency")]
        public string currency { get; private set; }
        [Display(Name = "disable_reason")]
        public int disableReason { get; private set; }
        [Display(Name = "end_advertiser")]
        public string endAdvertiser { get; private set; }
        [Display(Name = "end_advertiser_name")]
        public string endAdvertiserName { get; private set; }
        [Display(Name = "funding_source")]
        public string fundingSource { get; private set; }
        [Display(Name = "funding_source_details")]
        public fundingSourceDetails fundingSourceDetails { get; private set; }
        [Display(Name = "has_migrated_permissions")]
        public bool hasMigratedPermissions { get; private set; }
        [Display(Name = "is_attribution_spec_system_default")]
        public bool IsAttributionSpecSystemDefault { get; private set; }
        [Display(Name = "is_direct_deals_enabled")]
        public bool isDirectDealsEnabled { get; private set; }
        [Display(Name = "is_in_3ds_authorization_enabled_market")]
        public bool isIn3dsAuthorizationEnabledMarket { get; private set; }
        [Display(Name = "is_in_middle_of_local_entity_migration")]
        public bool isInMiddleOfLocalEntityMigration { get; private set; }
        [Display(Name = "is_notifications_enabled")]
        public bool isNotificationsEnabled { get; private set; }
        [Display(Name = "is_prepay_account")]
        public bool isPrepayAccount { get; private set; }
        [Display(Name = "is_tax_id_required")]
        public bool IsTaxIdRequired { get; private set; }
        [Display(Name = "min_campaign_group_spend_cap")]
        public string MinCampaignGroupSpendCap { get; private set; }
        [Display(Name= "min_daily_budget")]
        public string minDailyBudget { get; private set; }
        [Display(Name = "offsite_pixels_tos_accepted")]
        public bool OffsitePixelsTosAccepted { get; private set; }
        [Display(Name = "owner")]
        public string owner { get; private set; }
        [Display(Name= "timezone_id")]
        public string timezone_id { get; private set; }
        [Display(Name = "timezone_name")]
        public string timezoneName { get; private set; }
        [Display(Name = "timezone_offset_hours_utc")]
        public string timezoneOffsetHoursUtc { get; private set; }
        [Display(Name = "user_tasks")]
        public IEnumerable<string> userTasks { get; private set; }
        #region ParamsNotEntity


        public IEnumerable<Campaign> campaigns { get; set; }
        public IEnumerable<Campaign> GetCampaigns()
        {
            string request = business.account.baseUri + "act_" + id + $"/campaigns/?fields=name,id&access_token=" + business.account.getToken();
            campaigns = ParseJsonResponseHelper.ParseCampaigns(RequestHelper.SendPostRequest(request, business.account.getSettings));
            SetCampaignBusinessAndAdAccount();
            return campaigns;
        }
        private async Task<IEnumerable<Campaign>> GetCampaignsAsync()
        {
            return await Task.Run(() => GetCampaigns());
        }
        public async override void LoadReferencesObject()
        {
            var campaignA = GetCampaignsAsync();
            campaigns = campaignA.Result;

        }
        private void SetCampaignBusinessAndAdAccount()
        {
            foreach (var camp in campaigns)
            {
                camp.SetAdAccount(this);
                camp.SetBusiness(business);
            }

        }
        #endregion
    }
    public enum ACCOUNT_STATUS : int
    {
        ACTIVE = 1,
        DISABLED = 2,
        UNSETTLED = 3,
        PENDING_RISK_REVIEW = 7,
        PENDING_SETTLEMENT = 8,
        IN_GRACE_PERIOD = 9,
        PENDING_CLOSURE = 100,
        CLOSED = 101,
        ANY_ACTIVE = 201,
        ANY_CLOSED = 202
    }
    public enum DISABLE_REASON : int
    {
        NONE,
        ADS_INTEGRITY_POLICY,
        ADS_IP_REVIEW,
        RISK_PAYMENT,
        GRAY_ACCOUNT_SHUT_DOWN,
        ADS_AFC_REVIEW,
        BUSINESS_INTEGRITY_RAR,
        PERMANENT_CLOSE,
        UNUSED_RESELLER_ACCOUNT,
        UNUSED_ACCOUNT,
    }
    [Display(Name = "funding_source_details")]
    public class fundingSourceDetails
    {
        [Display(Name = "id")]
        public string name { get; private set; }
        [Display(Name = "display_string")]
        public string displayString { get; private set; }
    }

    public enum FUNDING_SOURCE_TYPE : int
    {
        UNSET,
        CREDIT_CARD,
        FACEBOOK_WALLET,
        FACEBOOK_PAID_CREDIT,
        FACEBOOK_EXTENDED_CREDIT,
        ORDER,
        INVOICE,
        FACEBOOK_TOKEN,
        EXTERNAL_FUNDING,
        FEE,
        FX,
        DISCOUNT,
        PAYPAL_BILLING_AGREEMENT,
        FS_NULL,
        EXTERNAL_DEPOSIT,
        TAX,
        DIRECT_DEBIT,
        DUMMY,
        ALTPAY,
        STORED_BALANCE,
    }
}
