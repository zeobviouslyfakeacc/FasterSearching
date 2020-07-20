using Harmony;

namespace FasterSearching {

	[HarmonyPatch(typeof(Container))]
	[HarmonyPatch("BeginContainerInteraction")]
	internal static class PatchFasterSearch {

		static void Prefix(ref float searchTimeSeconds, ref Container __instance) {
			if (__instance.m_Items.Count == 0 && FasterSearchingSettings.Instance.instantlySearchEmpty) {
				searchTimeSeconds = 0f;
			} else {
				searchTimeSeconds *= FasterSearchingSettings.Instance.searchTimeMultiplier;
			}
		}
	}
}
