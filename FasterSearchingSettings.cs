using ModSettings;

namespace FasterSearching {
	internal class FasterSearchingSettings : JsonModSettings {

		internal static FasterSearchingSettings Instance;

		[Name("Search time multiplier")]
		[Description("Determines how quickly containers should be searched, lower is faster. 1.0 = base speed, 0.0 = instant searching")]
		[Slider(0f, 1f, 11)]
		public float searchTimeMultiplier = 0.3f;

		[Name("Instantly search empty containers")]
		[Description("Whether containers that do not contain any items should be searched instantly.")]
		public bool instantlySearchEmpty = true;

		[Name("Open time multiplier")]
		[Description("Determines how quickly already-searched containers should be opened, lower is faster. 1.0 = base speed, 0.0 = instant opening")]
		[Slider(0f, 1f, 11)]
		public float openTimeMultiplier = 0.6f;
	}
}
