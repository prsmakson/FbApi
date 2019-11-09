using Fb.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Fb.Api.Models.Exstension;
using Fb.Api.Models.Intf;
using System.Threading.Tasks;

namespace Fb.Api.Models
{
	public class Campaign : IAdAccount, IBusiness, INameID, IReferences
	{
		public Campaign(Business business, AdAccount adAccount)
		{
			SetBusiness(business);
			SetAdAccount(adAccount);
		}
		public Campaign()
		{

		}
		[JsonProperty("name")]
		public string name { get; set; } = null;
		[JsonProperty("id")]
		public string id { get; set; } = null;
		[JsonProperty("adlabels")]
		public List<AdLabel> mAdlabels { get; private set; } = null;
		[JsonProperty("bid_strategy")]
		public EENUM_BID_STRATEGY? mBidStrategy { get; set; } = null;
		[JsonProperty("boosted_object_id")]
		public string boostedObjectId { get; private set; } = null;
		[JsonProperty("brand_lift_studies")]
		public List<AdStudy> brandLiftStudies { get; private set; } = null; //-- не загружается
		[JsonProperty("budget_rebalance_flag")]
		public bool? budgetRebalanceFlag { get; private set; } = null;
		[JsonProperty("budget_remaining")]
		public string budgetRemaining { get; private set; } = null;
		[JsonProperty("buying_type")]
		public string buyingType { get; set; } = null;
		[JsonProperty("can_create_brand_lift_study")]
		public bool? canCreateBrandLiftStudy { get; private set; } = null;
		[JsonProperty("can_use_spend_cap")]
		public bool? canUseSpendCap { get; private set; } = null;
		[JsonProperty("configured_status")]
		public CAMPAIGN_STATUS? configuredStatus { get; set; } = null;
		[JsonProperty("created_time")]
		public DateTime? сreatedTime { get; private set; } = null;
		[JsonProperty("daily_budget")]
		public string dailyBudget { get; set; } = null; //-- загружается
		[JsonProperty("effective_status")]
		public ENUM_EFFECTIVE_STATUS? effectiveStatus { get; set; } = null;
		[JsonProperty("issues_info")]
		public List<AdCampaignIssuesInfo> issuesInfo { get; private set; } = null;
		[JsonProperty("last_budget_toggling_time")]
		public string lastBudgetTogglingTime { get; private set; } = null;// -- не загружается
		[JsonProperty("lifetime_budget")]
		public string lifetimeBudget { get; private set; } = null; //- не загружается

		[JsonProperty("objective")]
		public ENUM_OBJECTIVE? objective { get; set; } = null;
		[JsonProperty("pacing_type")]
		public List<string> зacingType { get; private set; } = null; //-- не загружается
		[JsonProperty("promoted_object")]
		public AdPromotedObject mPromotedObject { get; set; } = null;
		[JsonProperty("recommendations")]
		public List<AdRecommendation> recommendations { get; private set; } = null;
		[JsonProperty("source_campaign")]
		public Campaign sourceCampaign { get; private set; } = null;// -- не загружается
		[JsonProperty("source_campaign_id")]
		public string sourceCampaignId { get; private set; } = null;
		[JsonProperty("special_ad_category")]
		public string specialAdCategory { get; private set; } = null;
		[JsonProperty("spend_cap")]
		public string spendCap { get; private set; } = null; //-- не загружается
		[JsonProperty("start_time")]
		public string startTime { get; private set; } = null;
		[JsonProperty("status")]
		public CAMPAIGN_STATUS? status { get; set; } = null;

		[JsonProperty("stop_time")]
		public string stopTime { get; private set; } = null; //-- не загружается
		[JsonProperty("topline_id")]
		public string toplineId { get; private set; } = null;
		[JsonProperty("updated_time")]
		public string updatedTime { get; private set; } = null;

		#region ParamsNotEntity
		[JsonProperty("account_id")]
		public string accountId { get; private set; }
		public AdAccount adAccount { get; private set; }
		public Business business { get; private set; }
		public IEnumerable<AdSet> adSets { get; private set; }
		public void SetAdAccount(AdAccount adAccount)
		{
			this.adAccount = adAccount;
		}
		public void SetBusiness(Business business)
		{
			this.business = business;
		}
		#endregion
		//public string buying_type { get => "AUCTION"; set { buying_type = value; } }   // 
		#region GetFunctions      
		public void LoadReferencesObject()
		{
			var adSets=GetAdSetsAsync();
			this.adSets = adSets.Result;
		}
		private void LoadAdsetReferences()
		{
			if(adSets!=null)
				foreach(var a in adSets)
					a.lo
		}
		public IEnumerable<AdSet> GetAdSets()
		{
			string request = business.account.baseUri + id + "?fields=adsets{" + typeof(AdSet).GetRequestGetstring() + "}&access_token=" + business.account.getToken();
			return ParseJsonResponseHelper.ParseAdsets(RequestHelper.SendGetRequest(request, business.account.getSettings));
		}
		public async Task<IEnumerable<AdSet>> GetAdSetsAsync()
		{
			return await Task.Run(() => GetAdSets());
		}
		#endregion
		#region SetFunctions
		public bool UpdateCampaign()
		{
			return true;
		}
		public string SetCampaignToFacebook()
		{
			string request = business.account.baseUri + adAccount.id + $"/campaigns/?{typeof(Campaign).GetRequestPostString(this)}" + $"&access_token={business.account.getToken()}";
			return ParseJsonResponseHelper.ParseResultOrId(RequestHelper.SendGetRequest(request, business.account.postSettings));
		}

		public void SetStatus()
		{

		}
		#endregion


		#region Enums
		public enum ENUM_EFFECTIVE_STATUS : int
		{
			[JsonProperty("ACTIVE")]
			ACTIVE,
			[JsonProperty("ARCHIVED")]
			ARCHIVED,
			[JsonProperty("DELETED")]
			DELETED,
			[JsonProperty("IN_PROCESS")]
			IN_PROCESS,
			[JsonProperty("PAUSED")]
			PAUSED,
			[JsonProperty("WITH_ISSUES")]
			WITH_ISSUES
		}

		public enum ENUM_OBJECTIVE : int
		{
			[JsonProperty("APP_INSTALLS")]
			APP_INSTALLS,
			[JsonProperty("BRAND_AWARENESS")]
			BRAND_AWARENESS,
			[JsonProperty("CONVERSIONS")]
			CONVERSIONS,
			[JsonProperty("EVENT_RESPONSES")]
			EVENT_RESPONSES,
			[JsonProperty("LEAD_GENERATION")]
			LEAD_GENERATION,
			[JsonProperty("LINK_CLICKS")]
			LINK_CLICKS,
			[JsonProperty("LOCAL_AWARENESS")]
			LOCAL_AWARENESS,
			[JsonProperty("MESSAGES")]
			MESSAGES,
			[JsonProperty("OFFER_CLAIMS")]
			OFFER_CLAIMS,
			[JsonProperty("PAGE_LIKES")]
			PAGE_LIKES,
			[JsonProperty("POST_ENGAGEMENT")]
			POST_ENGAGEMENT,
			[JsonProperty("PRODUCT_CATALOG_SALES")]
			PRODUCT_CATALOG_SALES,
			[JsonProperty("REACH")]
			REACH,
			[JsonProperty("VIDEO_VIEWS")]
			VIDEO_VIEWS
		}
		public enum CAMPAIGN_STATUS : int
		{
			[JsonProperty("ACTIVE")]
			ACTIVE,
			[JsonProperty("PAUSED")]
			PAUSED,
			[JsonProperty("DELETED")]
			DELETED,
			[JsonProperty("ARCHIVED")]
			ARCHIVED
		}
		public enum EENUM_BID_STRATEGY : int
		{
			VOWEST_COST_WITHOUT_CAP,
			LOWEST_COST_WITH_BID_CAP,
			TARGET_COST
		}
		#endregion


	}





}

