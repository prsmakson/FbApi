using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Fb.Api.Helpers;
using Newtonsoft.Json;
namespace Fb.Api.Models
{

    public class AdAccount : BaseBusiness
    {	
        public string adAccountId { get => "act_" + id; }
		[JsonProperty("account_status")]
        public ACCOUNT_STATUS accountStatus { get; set; }// сделать private
        [JsonProperty("age")]
        public double age { get; set; }
        [JsonProperty("amount_spent")]
        public string amountSpent { get; private set; }
        [JsonProperty("balance")]
        public string balance { get; private set; }
        [JsonProperty("business_city")]
        public string businessCity { get; private set; }
        [JsonProperty("business_country_code")]
        public string businessCountryCode { get; private set; }
        [JsonProperty("capabilities")]
        public IEnumerable<string> capabilities { get; private set; }
        [JsonProperty("created_time")]
        public DateTime createdTime { get; private set; }
        [JsonProperty("currency")]
        public string currency { get; private set; }
        [JsonProperty("disable_reason")]
        public int disableReason { get; private set; }
        [JsonProperty("end_advertiser")]
        public string endAdvertiser { get; private set; }
        [JsonProperty("end_advertiser_name")]
        public string endAdvertiserName { get; private set; }
        [JsonProperty("funding_source")]
        public string fundingSource { get; private set; }
        [JsonProperty("funding_source_details")]
        public fundingSourceDetails fundingSourceDetails { get; private set; }
        [JsonProperty("has_migrated_permissions")]
        public bool hasMigratedPermissions { get; private set; }
        [JsonProperty("is_attribution_spec_system_default")]
        public bool IsAttributionSpecSystemDefault { get; private set; }
        [JsonProperty("is_direct_deals_enabled")]
        public bool isDirectDealsEnabled { get; private set; }
        [JsonProperty("is_in_3ds_authorization_enabled_market")]
        public bool isIn3dsAuthorizationEnabledMarket { get; private set; }
        [JsonProperty("is_in_middle_of_local_entity_migration")]
        public bool isInMiddleOfLocalEntityMigration { get; private set; }
        [JsonProperty("is_notifications_enabled")]
        public bool isNotificationsEnabled { get; private set; }
        [JsonProperty("is_prepay_account")]
        public bool isPrepayAccount { get; private set; }
        [JsonProperty("is_tax_id_required")]
        public bool IsTaxIdRequired { get; private set; }
        [JsonProperty("min_campaign_group_spend_cap")]
        public string MinCampaignGroupSpendCap { get; private set; }
        [Display(Name= "min_daily_budget")]
        public string minDailyBudget { get; private set; }
        [JsonProperty("offsite_pixels_tos_accepted")]
        public bool OffsitePixelsTosAccepted { get; private set; }
        [JsonProperty("owner")]
        public string owner { get; private set; }
        [Display(Name= "timezone_id")]
        public string timezone_id { get; private set; }
        [JsonProperty("timezone_name")]
        public string timezoneName { get; private set; }
        [JsonProperty("timezone_offset_hours_utc")]
        public string timezoneOffsetHoursUtc { get; private set; }
        [JsonProperty("user_tasks")]
        public IEnumerable<string> userTasks { get; private set; }
        #region ParamsNotEntity


        public IEnumerable<Campaign> campaigns { get; set; }
        public IEnumerable<Campaign> GetCampaigns()
        {
            string request = business.account.baseUri + id + $"/campaigns/?fields=name,id&access_token=" + business.account.getToken();
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
    public class fundingSourceDetails
    {
        [JsonProperty("id")]
        public string name { get; private set; }
        [JsonProperty("display_string")]
        public string displaystring { get; private set; }
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
