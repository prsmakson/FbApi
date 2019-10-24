using Fb.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Fb.Api.Models
{
    public class Page : BaseBusiness
    {
        [Display(Name = "access_token")]
        public string accessToken { get; private set; }
        [Display(Name = "can_checkin")]
        public string canCheckin { get; private set; }
        [Display(Name = "can_post")]
        public string canPost { get; private set; }
        [Display(Name = "category")]
        public string category { get; private set; }
        [Display(Name = "country_page_likes")]
        public string countryPageLikes { get; private set; }
        [Display(Name = "fan_count")]
        public uint fanСount { get; private set; }
        [Display(Name = "global_brand_page_name")]
        public string global_brand_page_name { get; private set; }
        [Display(Name = "has_added_app")]
        public bool hasAddedApp { get; private set; }
        [Display(Name = "has_whatsapp_business_number")]
        public bool hasWhatsappBusinessNumber { get; private set; }
        [Display(Name = "has_whatsapp_number")]
        public bool hasWhatsappNumber { get; private set; }
        [Display(Name = "is_always_open")]
        public bool isAlwaysOpen { get; private set; }
        [Display(Name = "is_chain")]
        public bool isChain { get; private set; }
        [Display(Name = "is_community_page")]
        public bool isCommunityPage { get; private set; }
        [Display(Name = "is_eligible_for_branded_content")]
        public bool isEligibleForBrandedContent { get; private set; }
        [Display(Name = "is_messenger_bot_get_started_enabled")]
        public bool isMessengerBotGetStartedEnabled { get; private set; }
        [Display(Name = "is_messenger_platform_bot")]
        public bool isMessengerPlatformBot { get; private set; }
        [Display(Name = "is_owned")]
        public bool isOwned { get; private set; }
        [Display(Name = "is_permanently_closed")]
        public bool isPermanentlyClosed { get; private set; }
        [Display(Name = "is_published")]
        public bool isPublished { get; private set; }
        [Display(Name = "is_unclaimed")]
        public bool isUnclaimed { get; private set; }
        [Display(Name = "is_webhooks_subscribed")]
        public bool isWebhooksSubscribed { get; private set; }
        [Display(Name = "leadgen_has_crm_integration")]
        public bool leadgenHasCrmIntegration { get; private set; }
        [Display(Name = "leadgen_has_fat_ping_crm_integration")]
        public bool leadgenHasFatPingCrmIntegration { get; private set; }
        [Display(Name = "link")]
        public bool link { get; private set; }
        [Display(Name = "messenger_ads_default_icebreakers")]
        public List<string> messengerAdsDefaultIcebreakers { get; private set; }
        [Display(Name = "page_token")]
        public string pageToken { get; private set; }
        [Display(Name = "new_like_count")]
        public uint newLikeCount { get; private set; }
        [Display(Name = "offer_eligible")]
        public bool offerEligible { get; private set; }
        [Display(Name = "promotion_eligible")]
        public bool promotionEligible { get; private set; }
        [Display(Name = "rating_count")]
        public uint ratingCount { get; private set; }
        [Display(Name = "unread_message_count")]
        public uint unreadMessageCount { get; private set; }
        [Display(Name = "unread_notif_count")]
        public uint unreadNotifCount { get; private set; }
        [Display(Name = "unseen_message_count")]
        public uint unseenMessageCount { get; private set; }
        [Display(Name = "verification_status")]
        public string verificationStatus { get; private set; }
        [Display(Name = "voip_info")]
        public VoipInfo voipInfo { get; private set; }

        public bool LoadPageLogo(string logoUri = "https://tursar.ru/image/img2095_0.jpg")
        {

            string request = business.account.baseUri + id + "/picture/?picture=" + logoUri + "&access_token=" + access_token;
            var requestResult = RequestHelper.SendPostRequest(request, business.account.postSettings);
            return ParseJsonResponseHelper.ParseResultPostRequest(requestResult);
        }


    }
    public class VoipInfo
    {
        [Display(Name = "has_mobile_app")]
        public bool hasMobileApp { get; private set; }
        [Display(Name = "has_permission")]
        public bool hasPermission { get; private set; }
        [Display(Name = "is_callable")]
        public bool is_callable { get; private set; }
        [Display(Name = "is_callable_webrtc")]
        public bool isCallableWebrtc { get; private set; }
        [Display(Name = "is_pushable")]
        public bool isPushable { get; private set; }
        [Display(Name = "reason_code")]
        public uint reasonCode { get; private set; }
        [Display(Name = "reason_description")]
        public string reason_description { get; private set; }
    }
    //public class AppLinks
    //{
    //    [Display(Name = "app_name")]
    //    public string appName { get; private set; }
    //    [Display(Name = "package")]
    //    public string package { get; private set; }
    //    [Display(Name = "url")]
    //    public string url { get; private set; }
    //    [Display(Name = "app_store_id")]
    //    public string appStoreId { get; private set; }
    //}
}
