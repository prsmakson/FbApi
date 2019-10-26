using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	class User
	{
		[JsonProperty("about")]
		public string mAbout = null;
		//[JsonProperty("address")]
		//public Location mAddress = null;
		//[JsonProperty("admin_notes")]
		//public List<PageAdminNote> mAdminNotes = null;
		//[JsonProperty("age_range")]
		//public AgeRange mAgeRange = null;
		[JsonProperty("auth_method")]
		public string mAuthMethod = null;
		[JsonProperty("birthday")]
		public string mBirthday = null;
		[JsonProperty("can_review_measurement_request")]
		public bool? mCanReviewMeasurementRequest = null;
		//[JsonProperty("cover")]
		//public UserCoverPhoto mCover = null;
		//[JsonProperty("currency")]
		//public Currency mCurrency = null;
		//[JsonProperty("devices")]
		//public List<UserDevice> mDevices = null;
		[JsonProperty("education")]
		public List<Object> mEducation = null;
		[JsonProperty("email")]
		public string mEmail = null;
		//[JsonProperty("favorite_athletes")]
		//public List<Experience> mFavoriteAthletes = null;
		//[JsonProperty("favorite_teams")]
		//public List<Experience> mFavoriteTeams = null;
		[JsonProperty("first_name")]
		public string mFirstName = null;
		[JsonProperty("gender")]
		public string mGender = null;
		[JsonProperty("hometown")]
		public Page mHometown = null;
		[JsonProperty("id")]
		public string mId = null;
		//[JsonProperty("inspirational_people")]
		//public List<Experience> mInspirationalPeople = null;
		[JsonProperty("install_type")]
		public string mInstallType = null;
		[JsonProperty("installed")]
		public bool? mInstalled = null;
		[JsonProperty("interested_in")]
		public List<string> mInterestedIn = null;
		[JsonProperty("is_famedeeplinkinguser")]
		public bool? mIsFamedeeplinkinguser = null;
		[JsonProperty("is_shared_login")]
		public bool? mIsSharedLogin = null;
		[JsonProperty("is_verified")]
		public bool? mIsVerified = null;
		//[JsonProperty("labels")]
		//public List<PageLabel> mLabels = null;
		//[JsonProperty("languages")]
		//public List<Experience> mLanguages = null;
		[JsonProperty("last_name")]
		public string mLastName = null;
		[JsonProperty("link")]
		public string mLink = null;
		[JsonProperty("local_news_megaphone_dismiss_status")]
		public bool? mLocalNewsMegaphoneDismissStatus = null;
		[JsonProperty("local_news_subscription_status")]
		public bool? mLocalNewsSubscriptionStatus = null;
		[JsonProperty("locale")]
		public string mLocale = null;
		[JsonProperty("location")]
		public Page mLocation = null;
		[JsonProperty("meeting_for")]
		public List<string> mMeetingFor = null;
		[JsonProperty("middle_name")]
		public string mMiddleName = null;
		[JsonProperty("name")]
		public string mName = null;
		[JsonProperty("name_format")]
		public string mNameFormat = null;
		//[JsonProperty("payment_pricepoints")]
		//public PaymentPricepoints mPaymentPricepoints = null;
		[JsonProperty("political")]
		public string mPolitical = null;
		[JsonProperty("profile_pic")]
		public string mProfilePic = null;
		[JsonProperty("public_key")]
		public string mPublicKey = null;
		[JsonProperty("quotes")]
		public string mQuotes = null;
		[JsonProperty("relationship_status")]
		public string mRelationshipStatus = null;
		[JsonProperty("religion")]
		public string mReligion = null;
		//[JsonProperty("security_settings")]
		//public SecuritySettings mSecuritySettings = null;
		[JsonProperty("shared_login_upgrade_required_by")]
		public string mSharedLoginUpgradeRequiredBy = null;
		[JsonProperty("short_name")]
		public string mShortName = null;
		[JsonProperty("significant_other")]
		public User mSignificantOther = null;
		//[JsonProperty("sports")]
		//public List<Experience> mSports = null;
		//[JsonProperty("test_group")]
		//public Long mTestGroup = null;
		[JsonProperty("third_party_id")]
		public string mThirdPartyId = null;
		//[JsonProperty("timezone")]
		//public Double mTimezone = null;
		[JsonProperty("token_for_business")]
		public string mTokenForBusiness = null;
		[JsonProperty("updated_time")]
		public string mUpdatedTime = null;
		[JsonProperty("verified")]
		public bool? mVerified = null;
		//[JsonProperty("video_upload_limits")]
		//public VideoUploadLimits mVideoUploadLimits = null;
		[JsonProperty("viewer_can_send_gift")]
		public bool? mViewerCanSendGift = null;
		[JsonProperty("website")]
		public string mWebsite = null;
		[JsonProperty("work")]
		public List<Object> mWork = null;
	}
}
