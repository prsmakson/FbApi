using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeLinkDataImageOverlaySpec
	{
		[JsonProperty("custom_text_type")]
		public ENUM_CUSTOM_TEXT_TYPE? cstomTextType { get; private set; } = null;
		[JsonProperty("float_with_margin")]
		public bool? floatWithMargin { get; private set; } = null;
		[JsonProperty("overlay_template")]
		public ENUM_OVERLAY_TEMPLATE? overlayTemplate { get; private set; } = null;
		[JsonProperty("position")]
		public ENUM_POSITION? position { get; private set; } = null;
		[JsonProperty("text_font")]
		public ENUM_TEXT_FONT? textFont { get; private set; } = null;
		[JsonProperty("text_template_tags")]
		public List<string> textTemplateTags { get; private set; } = null;
		[JsonProperty("text_type")]
		public ENUM_TEXT_TYPE? textType { get; private set; } = null;
		[JsonProperty("theme_color")]
		public ENUM_THEME_COLOR? themeColor { get; private set; } = null;

		#region enums
		public enum ENUM_CUSTOM_TEXT_TYPE : int
		{
			free_shipping
		}
		public enum ENUM_OVERLAY_TEMPLATE : int
		{
			circle_with_text,
			pill_with_text,
			triangle_with_text



		}
		public enum ENUM_POSITION : int
		{
			bottom_left,
			bottom_right,
			top_left,
			top_right

		}
		public enum ENUM_TEXT_FONT : int
		{
			droid_serif_regular,
			dynads_hybrid_bold,
			lato_regular,
			noto_sans_regular,
			nunito_sans_bold,
			open_sans_bold,
			open_sans_condensed_bold,
			pt_serif_bold,
			roboto_condensed_regular,
			roboto_medium


		}
		public enum ENUM_TEXT_TYPE : int
		{
			custom,
			disclaimer,
			from_price,
			percentage_off,
			price,
			strikethrough_price


		}
		public enum ENUM_THEME_COLOR : int {
			background_000000_text_ffffff,

			background_0090ff_text_ffffff,

			background_00af4c_text_ffffff,

			background_595959_text_ffffff,

			background_755dde_text_ffffff,

			background_e50900_text_ffffff,

			background_f23474_text_ffffff,

			background_f78400_text_ffffff,

			background_ffffff_text_000000,

			background_ffffff_text_007ad0,

			background_ffffff_text_009c2a,

			background_ffffff_text_646464,

			background_ffffff_text_755dde,

			background_ffffff_text_c91b00,

			background_ffffff_text_f23474,

			background_ffffff_text_f78400,
		}
		#endregion
	}
}
