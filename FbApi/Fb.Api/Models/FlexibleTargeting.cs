using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class FlexibleTargeting
	{
		[JsonProperty("behaviors")]
		public List<IDName> mBehaviors { get; private set; } = null;
		[JsonProperty("college_years")]
		public List<long> mCollegeYears { get; private set; } = null;
		[JsonProperty("connections")]
		public List<IDName> mConnections { get; private set; } = null;
		[JsonProperty("custom_audiences")]
		public List<IDName> mCustomAudiences { get; private set; } = null;
		[JsonProperty("education_majors")]
		public List<IDName> mEducationMajors { get; private set; } = null;
		[JsonProperty("education_schools")]
		public List<IDName> mEducationSchools { get; private set; } = null;
		[JsonProperty("education_statuses")]
		public List<long> mEducationStatuses { get; private set; } = null;
		[JsonProperty("ethnic_affinity")]
		public List<IDName> mEthnicAffinity { get; private set; } = null;
		[JsonProperty("family_statuses")]
		public List<IDName> mFamilyStatuses { get; private set; } = null;
		[JsonProperty("friends_of_connections")]
		public List<IDName> mFriendsOfConnections { get; private set; } = null;
		[JsonProperty("generation")]
		public List<IDName> mGeneration { get; private set; } = null;
		[JsonProperty("home_ownership")]
		public List<IDName> mHomeOwnership { get; private set; } = null;
		[JsonProperty("home_type")]
		public List<IDName> mHomeType { get; private set; } = null;
		[JsonProperty("home_value")]
		public List<IDName> mHomeValue { get; private set; } = null;
		[JsonProperty("household_composition")]
		public List<IDName> mHouseholdComposition { get; private set; } = null;
		[JsonProperty("income")]
  public List<IDName> mIncome { get; private set; } = null;
		[JsonProperty("industries")]
		public List<IDName> mIndustries { get; private set; } = null;
		[JsonProperty("interested_in")]
		public List<long> mInterestedIn { get; private set; } = null;
		[JsonProperty("interests")]
		public List<IDName> mInterests { get; private set; } = null;
		[JsonProperty("life_events")]
		public List<IDName> mLifeEvents { get; private set; } = null;
		[JsonProperty("moms")]
  public List<IDName> mMoms { get; private set; } = null;
		[JsonProperty("net_worth")]
		public List<IDName> mNetWorth { get; private set; } = null;
		[JsonProperty("office_type")]
		public List<IDName> mOfficeType { get; private set; } = null;
		[JsonProperty("politics")]
		public List<IDName> mPolitics { get; private set; } = null;
		[JsonProperty("relationship_statuses")]
		public List<long> mRelationshipStatuses { get; private set; } = null;
		[JsonProperty("user_adclusters")]
		public List<IDName> mUserAdclusters { get; private set; } = null;
		[JsonProperty("work_employers")]
		public List<IDName> mWorkEmployers { get; private set; } = null;
		[JsonProperty("work_positions")]
		public List<IDName> mWorkPositions { get; private set; } = null;
	}
}
