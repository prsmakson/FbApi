using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class TargetingGeoLocation
	{
		[JsonProperty("cities")]
		public IEnumerable<TargetingGeoLocationCity> cities = null;
		[JsonProperty("countries")]
		public IEnumerable<string> countries = null;
		[JsonProperty("country_groups")]
		public IEnumerable<string> countryGroups = null;
		[JsonProperty("custom_locations")]
		public IEnumerable<TargetingGeoLocationCustomLocation> customLocations = null;
		[JsonProperty("electoral_districts")]
		public IEnumerable<TargetingGeoLocationElectoralDistrict> electoralDistricts = null;
		[JsonProperty("geo_markets")]
		public IEnumerable<TargetingGeoLocationMarket> geoMarkets = null;
		[JsonProperty("large_geo_areas")]
		public IEnumerable<TargetingGeoLocationGeoEntities> largeGeoAreas = null;
		[JsonProperty("location_cluster_ids")]
		public IEnumerable<TargetingGeoLocationLocationCluster> locationClusterIds = null;
		[JsonProperty("location_expansion")]
		public TargetingGeoLocationLocationExpansion locationExpansion = null;
		[JsonProperty("location_set_ids")]
		public IEnumerable<string> mLocationSetIds = null;
		[JsonProperty("location_types")]
		public IEnumerable<string> mLocationTypes = null;
		[JsonProperty("medium_geo_areas")]
		public IEnumerable<TargetingGeoLocationGeoEntities> mediumGeoAreas = null;
		[JsonProperty("metro_areas")]
		public IEnumerable<TargetingGeoLocationGeoEntities> metroAreas = null;
		[JsonProperty("neighborhoods")]
		public IEnumerable<TargetingGeoLocationGeoEntities> neighborhoods = null;
		[JsonProperty("places")]
		public IEnumerable<TargetingGeoLocationPlace> places = null;
		[JsonProperty("political_districts")]
		public IEnumerable<TargetingGeoLocationPoliticalDistrict> politicalDistricts = null;
		[JsonProperty("regions")]
		public IEnumerable<TargetingGeoLocationRegion> regions = null;
		[JsonProperty("small_geo_areas")]
		public IEnumerable<TargetingGeoLocationGeoEntities> smallGeoAreas = null;
		[JsonProperty("subcities")]
		public IEnumerable<TargetingGeoLocationGeoEntities> subcities = null;
		[JsonProperty("subneighborhoods")]
		public IEnumerable<TargetingGeoLocationGeoEntities> subneighborhoods = null;
		[JsonProperty("zips")]
		public IEnumerable<TargetingGeoLocationZip> zips = null;
	}
}
