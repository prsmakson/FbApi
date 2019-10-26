using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class Targeting
	{
		[JsonProperty("adgroup_id")]
		public string adgroupId { get; private set; } = null;
		[JsonProperty("age_max")]
		public long? ageMax { get; private set; } = null;
		[JsonProperty("age_min")]
		public long? ageMin { get; private set; } = null;
		[JsonProperty("alternate_auto_targeting_option")]
		public string alternateAutoTargetingOption { get; private set; } = null;
		[JsonProperty("app_install_state")]
		public string appInstallState { get; private set; } = null;
		[JsonProperty("audience_network_positions")]
		public IEnumerable<string> audienceNetworkPositions { get; private set; } = null;
		[JsonProperty("behaviors")]
		public IEnumerable<IDName> behaviors { get; private set; } = null;
		[JsonProperty("brand_safety_content_filter_levels")]
		public IEnumerable<string> brandSafetyContentFilterLevels { get; private set; } = null;
		[JsonProperty("catalog_based_targeting")]
		public CatalogBasedTargeting catalogBasedTargeting { get; private set; } = null;
		[JsonProperty("cities")]
		public IEnumerable<IDName> cities { get; private set; } = null;
		[JsonProperty("college_years")]
		public IEnumerable<long> collegeYears { get; private set; } = null;
		[JsonProperty("connections")]
		public IEnumerable<IDName> connections { get; private set; } = null;
		[JsonProperty("contextual_targeting_categories")]
		public IEnumerable<IDName> contextualTargetingCategories { get; private set; } = null;
		[JsonProperty("countries")]
		public IEnumerable<string> countries { get; private set; } = null;
		[JsonProperty("country")]
		public IEnumerable<string> country { get; private set; } = null;
		[JsonProperty("country_groups")]
		public IEnumerable<string> countryGroups { get; private set; } = null;
		//[JsonProperty("custom_audiences")]
		//public IEnumerable<RawCustomAudience> mCustomAudiences { get; private set; } = null;
		[JsonProperty("device_platforms")]
		public IEnumerable<DEVICE_PLATFORMS> devicePlatforms { get; private set; } = null;
		[JsonProperty("direct_install_devices")]
		public bool? directInstallDevices { get; private set; } = null;
		[JsonProperty("dynamic_audience_ids")]
		public IEnumerable<string> dynamicAudienceIds { get; private set; } = null;
		[JsonProperty("education_majors")]
		public IEnumerable<IDName> educationMajors { get; private set; } = null;
		[JsonProperty("education_schools")]
		public IEnumerable<IDName> educationSchools { get; private set; } = null;
		[JsonProperty("education_statuses")]
		public IEnumerable<long> educationStatuses { get; private set; } = null;
		[JsonProperty("effective_audience_network_positions")]
		public IEnumerable<string> effectiveAudienceNetworkPositions { get; private set; } = null;
		[JsonProperty("effective_device_platforms")]
		public IEnumerable<ENUM_EFFECTIVE_DEVICE_PLATFORMS> effectiveDevicePlatforms { get; private set; } = null;
		[JsonProperty("effective_facebook_positions")]
		public IEnumerable<string> effectiveFacebookPositions { get; private set; } = null;
		[JsonProperty("effective_instagram_positions")]
		public IEnumerable<string> effectiveInstagramPositions { get; private set; } = null;
		[JsonProperty("effective_messenger_positions")]
		public IEnumerable<string> effectiveMessengerPositions { get; private set; } = null;
		[JsonProperty("effective_publisher_platforms")]
		public IEnumerable<string> effectivePublisherPlatforms { get; private set; } = null;
		[JsonProperty("engagement_specs")]
		public IEnumerable<TargetingDynamicRule> engagementSpecs { get; private set; } = null;
		[JsonProperty("ethnic_affinity")]
		public IEnumerable<IDName> ethnicAffinity { get; private set; } = null;
		[JsonProperty("exclude_reached_since")]
		public IEnumerable<string> excludeReachedSince { get; private set; } = null;
		[JsonProperty("excluded_brand_safety_content_types")]
		public IEnumerable<string> excludedBrandSafetyContentTypes { get; private set; } = null;
		[JsonProperty("excluded_connections")]
		public IEnumerable<IDName> excludedConnections { get; private set; } = null;
		[JsonProperty("excluded_custom_audiences")]
		public IEnumerable<RawCustomAudience> excludedCustomAudiences { get; private set; } = null;
		[JsonProperty("excluded_dynamic_audience_ids")]
		public IEnumerable<string> excludedDynamicAudienceIds { get; private set; } = null;
		[JsonProperty("excluded_engagement_specs")]
		public IEnumerable<TargetingDynamicRule> excludedEngagementSpecs { get; private set; } = null;
		[JsonProperty("excluded_geo_locations")]
		public TargetingGeoLocation excludedGeoLocations { get; private set; } = null;
		[JsonProperty("excluded_mobile_device_model")]
		public IEnumerable<string> excludedMobileDeviceModel { get; private set; } = null;
		[JsonProperty("excluded_product_audience_specs")]
		public IEnumerable<TargetingProductAudienceSpec> excludedProductAudienceSpecs { get; private set; } = null;
		[JsonProperty("excluded_publisher_categories")]
		public IEnumerable<string> excludedPublisherCategories { get; private set; } = null;
		[JsonProperty("excluded_publisher_IEnumerable_ids")]
		public IEnumerable<string> excludedPublisherIEnumerableIds { get; private set; } = null;
		[JsonProperty("excluded_user_device")]
		public IEnumerable<string> excludedUserDevice { get; private set; } = null;
		[JsonProperty("exclusions")]
		public FlexibleTargeting exclusions { get; private set; } = null;
		[JsonProperty("facebook_positions")]
		public IEnumerable<string> facebookPositions { get; private set; } = null;
		[JsonProperty("family_statuses")]
		public IEnumerable<IDName> familyStatuses { get; private set; } = null;
		[JsonProperty("fb_deal_id")]
		public string mFbDealId { get; private set; } = null;
		[JsonProperty("flexible_spec")]
		public IEnumerable<FlexibleTargeting> flexibleSpec { get; private set; } = null;
		[JsonProperty("friends_of_connections")]
		public IEnumerable<IDName> friendsOfConnections { get; private set; } = null;
		[JsonProperty("genders")]
		public IEnumerable<long> genders { get; private set; } = null;
		//[JsonProperty("generation")]
		// public IEnumerable<IDName> mGeneration { get; private set; } = null;
		[JsonProperty("geo_locations")]
		public TargetingGeoLocation geoLocations { get; private set; } = null;
		[JsonProperty("home_ownership")]
		public IEnumerable<IDName> homeOwnership { get; private set; } = null;
		[JsonProperty("home_type")]
		public IEnumerable<IDName> homeType { get; private set; } = null;
		[JsonProperty("home_value")]
		public IEnumerable<IDName> homeValue { get; private set; } = null;
		[JsonProperty("household_composition")]
		public IEnumerable<IDName> householdComposition { get; private set; } = null;
		[JsonProperty("income")]
		public IEnumerable<IDName> income { get; private set; } = null;
		[JsonProperty("industries")]
		public IEnumerable<IDName> industries { get; private set; } = null;
		[JsonProperty("instagram_positions")]
		public IEnumerable<string> instagramPositions { get; private set; } = null;
		[JsonProperty("interested_in")]
		public IEnumerable<long> interestedIn { get; private set; } = null;
		[JsonProperty("interests")]
		public IEnumerable<IDName> interests { get; private set; } = null;
		[JsonProperty("is_whatsapp_destination_ad")]
		public bool? isWhatsappDestinationAd { get; private set; } = null;
		[JsonProperty("keywords")]
		public IEnumerable<string> keywords { get; private set; } = null;
		[JsonProperty("life_events")]
		public IEnumerable<IDName> lifeEvents { get; private set; } = null;
		[JsonProperty("locales")]
		public IEnumerable<long> locales { get; private set; } = null;
		[JsonProperty("messenger_positions")]
		public IEnumerable<string> messengerPositions { get; private set; } = null;
		[JsonProperty("moms")]
		public IEnumerable<IDName> moms { get; private set; } = null;
		[JsonProperty("net_worth")]
		public IEnumerable<IDName> netWorth { get; private set; } = null;
		[JsonProperty("office_type")]
		public IEnumerable<IDName> officeType { get; private set; } = null;
		[JsonProperty("place_page_set_ids")]
		public IEnumerable<string> placePageSetIds { get; private set; } = null;
		[JsonProperty("political_views")]
		public IEnumerable<long> politicalViews { get; private set; } = null;
		[JsonProperty("politics")]
		public IEnumerable<IDName> politics { get; private set; } = null;
		[JsonProperty("product_audience_specs")]
		public IEnumerable<TargetingProductAudienceSpec> productAudienceSpecs { get; private set; } = null;
		[JsonProperty("prospecting_audience")]
		public TargetingProspectingAudience prospectingAudience { get; private set; } = null;
		[JsonProperty("publisher_platforms")]
		public IEnumerable<string> publisherPlatforms { get; private set; } = null;
		[JsonProperty("radius")]
		public string radius { get; private set; } = null;
		[JsonProperty("regions")]
		public IEnumerable<IDName> regions { get; private set; } = null;
		[JsonProperty("relationship_statuses")]
		public IEnumerable<long> relationshipStatuses { get; private set; } = null;
		[JsonProperty("site_category")]
		public IEnumerable<string> siteCategory { get; private set; } = null;
		[JsonProperty("targeting_optimization")]
		public string mTargetingOptimization { get; private set; } = null;
		[JsonProperty("user_adclusters")]
		public IEnumerable<IDName> userAdclusters { get; private set; } = null;
		[JsonProperty("user_device")]
		public IEnumerable<string> mUserDevice { get; private set; } = null;
		[JsonProperty("user_event")]
		public IEnumerable<long> userEvent { get; private set; } = null;
		[JsonProperty("user_os")]
		public IEnumerable<string> userOs { get; private set; } = null;
		[JsonProperty("wireless_carrier")]
		public IEnumerable<string> wirelessCarrier { get; private set; } = null;
		[JsonProperty("work_employers")]
		public IEnumerable<IDName> workEmployers { get; private set; } = null;
		[JsonProperty("work_positions")]
		public IEnumerable<IDName> workPositions { get; private set; } = null;
		[JsonProperty("zips")]
		public IEnumerable<string> zips { get; private set; } = null;
	}
	public enum DEVICE_PLATFORMS : int
	{
		connected_tv,
		desktop,
		mobile
	}
	public enum ENUM_EFFECTIVE_DEVICE_PLATFORMS : int
	{
		connected_tv,
		desktop,
		mobile

	}
}