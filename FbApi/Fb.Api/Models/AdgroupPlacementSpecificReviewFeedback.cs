using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdgroupPlacementSpecificReviewFeedback
	{
		[JsonProperty("account_admin")]
		public Dictionary<string, string> accountAdmin = null;
		[JsonProperty("ad")]
		public Dictionary<string, string> ad = null;
		[JsonProperty("b2c")]
		public Dictionary<string, string> b2c = null;
		[JsonProperty("bsg")]
		public Dictionary<string, string> bsg = null;
		[JsonProperty("city_community")]
		public Dictionary<string, string> cityCommunity = null;
		[JsonProperty("daily_deals")]
		public Dictionary<string, string> dailyDeals = null;
		[JsonProperty("daily_deals_legacy")]
		public Dictionary<string, string> dailyDealsLegacy = null;
		[JsonProperty("dpa")]
		public Dictionary<string, string> dpa = null;
		[JsonProperty("facebook")]
		public Dictionary<string, string> facebook = null;
		[JsonProperty("instagram")]
		public Dictionary<string, string> instagram = null;
		[JsonProperty("instagram_shop")]
		public Dictionary<string, string> instagramShop = null;
		[JsonProperty("lead_gen_honeypot")]
		public Dictionary<string, string> leadGenHoneypot = null;
		[JsonProperty("marketplace")]
		public Dictionary<string, string> marketplace = null;
		[JsonProperty("marketplace_home_rentals")]
		public Dictionary<string, string> marketplaceHomeRentals = null;
		[JsonProperty("marketplace_home_sales")]
		public Dictionary<string, string> marketplaceHomeSales = null;
		[JsonProperty("marketplace_motors")]
		public Dictionary<string, string> marketplaceMotors = null;
		[JsonProperty("marketplace_shops")]
		public Dictionary<string, string> marketplaceShops = null;
		[JsonProperty("max_review_placements")]
		public Dictionary<string, string> maxReviewPlacements = null;
		[JsonProperty("page_admin")]
		public Dictionary<string, string> pageAdmin = null;
		[JsonProperty("product")]
		public Dictionary<string, string> product = null;
		[JsonProperty("product_service")]
		public Dictionary<string, string> productService = null;
		[JsonProperty("profile")]
		public Dictionary<string, string> profile = null;
		[JsonProperty("seller")]
		public Dictionary<string, string> seller = null;
		[JsonProperty("shops")]
		public Dictionary<string, string> shops = null;
		[JsonProperty("traffic_quality")]
		public Dictionary<string, string> trafficQuality = null;
		[JsonProperty("whatsapp")]
		public Dictionary<string, string> whatsapp = null;
	}
}
