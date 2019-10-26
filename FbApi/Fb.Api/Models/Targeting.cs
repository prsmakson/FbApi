using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class Targeting
	{
		[JsonProperty("adgroup_id")]
		public string mAdgroupId { get; private set; } = null;
		[JsonProperty("age_max")]
		public long? mAgeMax { get; private set; } = null;
		[JsonProperty("age_min")]
		public long? mAgeMin { get; private set; } = null;
		[JsonProperty("alternate_auto_targeting_option")]
		public string mAlternateAutoTargetingOption { get; private set; } = null;
		[JsonProperty("app_install_state")]
		public string mAppInstallState { get; private set; } = null;
		[JsonProperty("audience_network_positions")]
		public IEnumerable<string> mAudienceNetworkPositions { get; private set; } = null;
		[JsonProperty("behaviors")]
		public IEnumerable<IDName> mBehaviors { get; private set; } = null;
		[JsonProperty("brand_safety_content_filter_levels")]
		public IEnumerable<string> mBrandSafetyContentFilterLevels { get; private set; } = null;
		[JsonProperty("catalog_based_targeting")]
		public CatalogBasedTargeting mCatalogBasedTargeting { get; private set; } = null;
		[JsonProperty("cities")]
		public IEnumerable<IDName> mCities { get; private set; } = null;
		[JsonProperty("college_years")]
		public IEnumerable<long> mCollegeYears { get; private set; } = null;
		[JsonProperty("connections")]
		public IEnumerable<IDName> mConnections { get; private set; } = null;
		[JsonProperty("contextual_targeting_categories")]
		public IEnumerable<IDName> mContextualTargetingCategories { get; private set; } = null;
		[JsonProperty("countries")]
		public IEnumerable<string> mCountries { get; private set; } = null;
		[JsonProperty("country")]
		public IEnumerable<string> mCountry { get; private set; } = null;
		[JsonProperty("country_groups")]
		public IEnumerable<string> mCountryGroups { get; private set; } = null;
		//[JsonProperty("custom_audiences")]
		//public IEnumerable<RawCustomAudience> mCustomAudiences { get; private set; } = null;
		[JsonProperty("device_platforms")]
		public IEnumerable<DEVICE_PLATFORMS> mDevicePlatforms { get; private set; } = null;
		[JsonProperty("direct_install_devices")]
		public bool? mDirectInstallDevices { get; private set; } = null;
		[JsonProperty("dynamic_audience_ids")]
		public IEnumerable<string> mDynamicAudienceIds { get; private set; } = null;
		[JsonProperty("education_majors")]
		public IEnumerable<IDName> mEducationMajors { get; private set; } = null;
		[JsonProperty("education_schools")]
		public IEnumerable<IDName> mEducationSchools { get; private set; } = null;
		[JsonProperty("education_statuses")]
		public IEnumerable<long> mEducationStatuses { get; private set; } = null;
		[JsonProperty("effective_audience_network_positions")]
		public IEnumerable<string> mEffectiveAudienceNetworkPositions { get; private set; } = null;
		[JsonProperty("effective_device_platforms")]
		public IEnumerable<ENUM_EFFECTIVE_DEVICE_PLATFORMS> mEffectiveDevicePlatforms { get; private set; } = null;
		[JsonProperty("effective_facebook_positions")]
		public IEnumerable<string> mEffectiveFacebookPositions { get; private set; } = null;
		[JsonProperty("effective_instagram_positions")]
		public IEnumerable<string> mEffectiveInstagramPositions { get; private set; } = null;
		[JsonProperty("effective_messenger_positions")]
		public IEnumerable<string> mEffectiveMessengerPositions { get; private set; } = null;
		[JsonProperty("effective_publisher_platforms")]
		public IEnumerable<string> mEffectivePublisherPlatforms { get; private set; } = null;
		[JsonProperty("engagement_specs")]
		public IEnumerable<TargetingDynamicRule> mEngagementSpecs { get; private set; } = null;
		[JsonProperty("ethnic_affinity")]
		public IEnumerable<IDName> mEthnicAffinity { get; private set; } = null;
		[JsonProperty("exclude_reached_since")]
		public IEnumerable<string> mExcludeReachedSince { get; private set; } = null;
		[JsonProperty("excluded_brand_safety_content_types")]
		public IEnumerable<string> mExcludedBrandSafetyContentTypes { get; private set; } = null;
		[JsonProperty("excluded_connections")]
		public IEnumerable<IDName> mExcludedConnections { get; private set; } = null;
		[JsonProperty("excluded_custom_audiences")]
		public IEnumerable<RawCustomAudience> mExcludedCustomAudiences { get; private set; } = null;
		[JsonProperty("excluded_dynamic_audience_ids")]
		public IEnumerable<string> mExcludedDynamicAudienceIds { get; private set; } = null;
		[JsonProperty("excluded_engagement_specs")]
		public IEnumerable<TargetingDynamicRule> mExcludedEngagementSpecs { get; private set; } = null;
		[JsonProperty("excluded_geo_locations")]
		public TargetingGeoLocation mExcludedGeoLocations { get; private set; } = null;
		[JsonProperty("excluded_mobile_device_model")]
		public IEnumerable<string> mExcludedMobileDeviceModel { get; private set; } = null;
		[JsonProperty("excluded_product_audience_specs")]
		public IEnumerable<TargetingProductAudienceSpec> mExcludedProductAudienceSpecs { get; private set; } = null;
		[JsonProperty("excluded_publisher_categories")]
		public IEnumerable<string> mExcludedPublisherCategories { get; private set; } = null;
		[JsonProperty("excluded_publisher_IEnumerable_ids")]
		public IEnumerable<string> mExcludedPublisherIEnumerableIds { get; private set; } = null;
		[JsonProperty("excluded_user_device")]
		public IEnumerable<string> mExcludedUserDevice { get; private set; } = null;
		[JsonProperty("exclusions")]
		public FlexibleTargeting mExclusions { get; private set; } = null;
		[JsonProperty("facebook_positions")]
		public IEnumerable<string> mFacebookPositions { get; private set; } = null;
		[JsonProperty("family_statuses")]
		public IEnumerable<IDName> mFamilyStatuses { get; private set; } = null;
		[JsonProperty("fb_deal_id")]
		public string mFbDealId { get; private set; } = null;
		[JsonProperty("flexible_spec")]
		public IEnumerable<FlexibleTargeting> mFlexibleSpec { get; private set; } = null;
		[JsonProperty("friends_of_connections")]
		public IEnumerable<IDName> mFriendsOfConnections { get; private set; } = null;
		[JsonProperty("genders")]
		public IEnumerable<long> mGenders { get; private set; } = null;
		//[JsonProperty("generation")]
		// public IEnumerable<IDName> mGeneration { get; private set; } = null;
		[JsonProperty("geo_locations")]
		public TargetingGeoLocation mGeoLocations { get; private set; } = null;
		[JsonProperty("home_ownership")]
		public IEnumerable<IDName> mHomeOwnership { get; private set; } = null;
		[JsonProperty("home_type")]
		public IEnumerable<IDName> mHomeType { get; private set; } = null;
		[JsonProperty("home_value")]
		public IEnumerable<IDName> mHomeValue { get; private set; } = null;
		[JsonProperty("household_composition")]
		public IEnumerable<IDName> mHouseholdComposition { get; private set; } = null;
		[JsonProperty("income")]
		public IEnumerable<IDName> mIncome { get; private set; } = null;
		[JsonProperty("industries")]
		public IEnumerable<IDName> mIndustries { get; private set; } = null;
		[JsonProperty("instagram_positions")]
		public IEnumerable<string> mInstagramPositions { get; private set; } = null;
		[JsonProperty("interested_in")]
		public IEnumerable<long> mInterestedIn { get; private set; } = null;
		[JsonProperty("interests")]
		public IEnumerable<IDName> mInterests { get; private set; } = null;
		[JsonProperty("is_whatsapp_destination_ad")]
		public bool? mIsWhatsappDestinationAd { get; private set; } = null;
		[JsonProperty("keywords")]
		public IEnumerable<string> mKeywords { get; private set; } = null;
		[JsonProperty("life_events")]
		public IEnumerable<IDName> mLifeEvents { get; private set; } = null;
		[JsonProperty("locales")]
		public IEnumerable<long> mLocales { get; private set; } = null;
		[JsonProperty("messenger_positions")]
		public IEnumerable<string> mMessengerPositions { get; private set; } = null;
		[JsonProperty("moms")]
		public IEnumerable<IDName> mMoms { get; private set; } = null;
		[JsonProperty("net_worth")]
		public IEnumerable<IDName> mNetWorth { get; private set; } = null;
		[JsonProperty("office_type")]
		public IEnumerable<IDName> mOfficeType { get; private set; } = null;
		[JsonProperty("place_page_set_ids")]
		public IEnumerable<string> mPlacePageSetIds { get; private set; } = null;
		[JsonProperty("political_views")]
		public IEnumerable<long> mPoliticalViews { get; private set; } = null;
		[JsonProperty("politics")]
		public IEnumerable<IDName> mPolitics { get; private set; } = null;
		[JsonProperty("product_audience_specs")]
		public IEnumerable<TargetingProductAudienceSpec> mProductAudienceSpecs { get; private set; } = null;
		[JsonProperty("prospecting_audience")]
		public TargetingProspectingAudience mProspectingAudience { get; private set; } = null;
		[JsonProperty("publisher_platforms")]
		public IEnumerable<string> mPublisherPlatforms { get; private set; } = null;
		[JsonProperty("radius")]
		public string mRadius { get; private set; } = null;
		[JsonProperty("regions")]
		public IEnumerable<IDName> mRegions { get; private set; } = null;
		[JsonProperty("relationship_statuses")]
		public IEnumerable<long> mRelationshipStatuses { get; private set; } = null;
		[JsonProperty("site_category")]
		public IEnumerable<string> mSiteCategory { get; private set; } = null;
		[JsonProperty("targeting_optimization")]
		public string mTargetingOptimization { get; private set; } = null;
		[JsonProperty("user_adclusters")]
		public IEnumerable<IDName> mUserAdclusters { get; private set; } = null;
		[JsonProperty("user_device")]
		public IEnumerable<string> mUserDevice { get; private set; } = null;
		[JsonProperty("user_event")]
		public IEnumerable<long> mUserEvent { get; private set; } = null;
		[JsonProperty("user_os")]
		public IEnumerable<string> mUserOs { get; private set; } = null;
		[JsonProperty("wireless_carrier")]
		public IEnumerable<string> mWirelessCarrier { get; private set; } = null;
		[JsonProperty("work_employers")]
		public IEnumerable<IDName> mWorkEmployers { get; private set; } = null;
		[JsonProperty("work_positions")]
		public IEnumerable<IDName> mWorkPositions { get; private set; } = null;
		[JsonProperty("zips")]
		public IEnumerable<string> mZips { get; private set; } = null;
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