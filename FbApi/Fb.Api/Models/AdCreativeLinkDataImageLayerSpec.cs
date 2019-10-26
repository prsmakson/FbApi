using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models
{
	public class AdCreativeLinkDataImageLayerSpec
	{
		[JsonProperty("blending_mode")]
		public ENUM_BLENDING_MODE? blendingMode { get; private set; } = null;
		[JsonProperty("content")]
		public object content { get; private set; } = null;
		[JsonProperty("frame_image_hash")]
		public string frameImageHash { get; private set; } = null;
		[JsonProperty("frame_source")]
		public ENUM_FRAME_SOURCE? frameSource { get; private set; } = null;
		[JsonProperty("image_source")]
		public ENUM_IMAGE_SOURCE? imageSource { get; private set; } = null;
		[JsonProperty("layer_type")]
		public ENUM_LAYER_TYPE? layerType { get; private set; } = null;
		[JsonProperty("opacity")]
		public long? opacity { get; private set; } = null;
		[JsonProperty("overlay_position")]
		public ENUM_OVERLAY_POSITION? overlayPosition { get; private set; } = null;
		[JsonProperty("overlay_shape")]
		public ENUM_OVERLAY_SHARPE? overlayShape { get; private set; } = null;
		[JsonProperty("scale")]
		public long? scale { get; private set; } = null;
		[JsonProperty("shape_color")]
		public string shapeColor { get; private set; } = null;
		[JsonProperty("text_color")]
		public string textColor { get; private set; } = null;
		[JsonProperty("text_font")]
		public ENUM_TEXT_FONT? textFont { get; private set; } = null;

		#region enums
		public enum ENUM_BLENDING_MODE : int
		{
			lighten,
			multiply,
			normal


		}
		public enum ENUM_FRAME_SOURCE : int
		{
			custom
		}
		public enum ENUM_IMAGE_SOURCE : int
		{
			catalog

		}
		public enum ENUM_LAYER_TYPE : int
		{
			frame_overlay,
			image,
			text_overlay


		}
		public enum ENUM_OVERLAY_POSITION : int
		{
			bottom,
			bottom_left,
			bottom_right,
			center,
			left,
			right,
			top,
			top_left,
			top_right


		}
		public enum ENUM_OVERLAY_SHARPE : int
		{
			circle,
			none,
			pill,
			rectangle,
			triangle


		}
		public enum ENUM_TEXT_FONT : int
		{
			droid_serif_regular,
			lato_regular,
			noto_sans_regular,
			nunito_sans_bold,
			open_sans_bold,
			open_sans_condensed_bold,
			pt_serif_bold,
			roboto_condensed_regular,
			roboto_medium


		}
		#endregion

	}
}
