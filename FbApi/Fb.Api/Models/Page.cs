using Fb.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Fb.Api.Models
{
    public class Page : BaseBusiness
    {
        [JsonProperty("access_token")]
        public string accessToken { get; private set; }
        [JsonProperty("can_checkin")]
        public string canCheckin { get; private set; }
        [JsonProperty("can_post")]
        public string canPost { get; private set; }
        [JsonProperty("category")]
        public string category { get; private set; }
        [JsonProperty("country_page_likes")]
        public string countryPageLikes { get; private set; }
        [JsonProperty("fan_count")]
        public uint fanСount { get; private set; }
        [JsonProperty("global_brand_page_name")]
        public string global_brand_page_name { get; private set; }
        [JsonProperty("has_added_app")]
        public bool hasAddedApp { get; private set; }
        [JsonProperty("has_whatsapp_business_number")]
        public bool hasWhatsappBusinessNumber { get; private set; }
        [JsonProperty("has_whatsapp_number")]
        public bool hasWhatsappNumber { get; private set; }
        [JsonProperty("is_always_open")]
        public bool isAlwaysOpen { get; private set; }
        [JsonProperty("is_chain")]
        public bool isChain { get; private set; }
        [JsonProperty("is_community_page")]
        public bool isCommunityPage { get; private set; }
        [JsonProperty("is_eligible_for_branded_content")]
        public bool isEligibleForBrandedContent { get; private set; }
        [JsonProperty("is_messenger_bot_get_started_enabled")]
        public bool isMessengerBotGetStartedEnabled { get; private set; }
        [JsonProperty("is_messenger_platform_bot")]
        public bool isMessengerPlatformBot { get; private set; }
        [JsonProperty("is_owned")]
        public bool isOwned { get; private set; }
        [JsonProperty("is_permanently_closed")]
        public bool isPermanentlyClosed { get; private set; }
        [JsonProperty("is_published")]
        public bool isPublished { get; private set; }
        [JsonProperty("is_unclaimed")]
        public bool isUnclaimed { get; private set; }
        [JsonProperty("is_webhooks_subscribed")]
        public bool isWebhooksSubscribed { get; private set; }
        [JsonProperty("leadgen_has_crm_integration")]
        public bool leadgenHasCrmIntegration { get; private set; }
        [JsonProperty("leadgen_has_fat_ping_crm_integration")]
        public bool leadgenHasFatPingCrmIntegration { get; private set; }
        [JsonProperty("link")]
        public bool link { get; private set; }
        [JsonProperty("messenger_ads_default_icebreakers")]
        public List<string> messengerAdsDefaultIcebreakers { get; private set; }
        [JsonProperty("page_token")]
        public string pageToken { get; private set; }
        [JsonProperty("new_like_count")]
        public uint newLikeCount { get; private set; }
        [JsonProperty("offer_eligible")]
        public bool offerEligible { get; private set; }
        [JsonProperty("promotion_eligible")]
        public bool promotionEligible { get; private set; }
        [JsonProperty("rating_count")]
        public uint ratingCount { get; private set; }
        [JsonProperty("unread_message_count")]
        public uint unreadMessageCount { get; private set; }
        [JsonProperty("unread_notif_count")]
        public uint unreadNotifCount { get; private set; }
        [JsonProperty("unseen_message_count")]
        public uint unseenMessageCount { get; private set; }
        [JsonProperty("verification_status")]
        public string verificationStatus { get; private set; }
        [JsonProperty("voip_info")]
        public VoipInfo voipInfo { get; private set; }

        public bool LoadPageLogo(string logoUri = "https://tursar.ru/image/img2095_0.jpg")
        {

            string request = business.account.baseUri + id + "/picture/?picture=" + logoUri + "&access_token=" + accessToken;
            var requestResult = RequestHelper.SendPostRequest(request, business.account.postSettings);
            return ParseJsonResponseHelper.ParseResultPostRequest(requestResult);
        }


    }
    public class VoipInfo
    {
        [JsonProperty("has_mobile_app")]
        public bool hasMobileApp { get; private set; }
        [JsonProperty("has_permission")]
        public bool hasPermission { get; private set; }
        [JsonProperty("is_callable")]
        public bool is_callable { get; private set; }
        [JsonProperty("is_callable_webrtc")]
        public bool isCallableWebrtc { get; private set; }
        [JsonProperty("is_pushable")]
        public bool isPushable { get; private set; }
        [JsonProperty("reason_code")]
        public uint reasonCode { get; private set; }
        [JsonProperty("reason_description")]
        public string reason_description { get; private set; }
    }
    //public class AppLinks
    //{
    //    [JsonProperty("app_name")]
    //    public string appName { get; private set; }
    //    [JsonProperty("package")]
    //    public string package { get; private set; }
    //    [JsonProperty("url")]
    //    public string url { get; private set; }
    //    [JsonProperty("app_store_id")]
    //    public string appStoreId { get; private set; }
    //}
}
