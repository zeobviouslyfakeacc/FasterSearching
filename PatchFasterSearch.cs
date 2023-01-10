using HarmonyLib;
using Il2Cpp;

namespace FasterSearching {

	[HarmonyPatch(typeof(ContainerInteraction), "PerformHold")]
	internal static class PatchFasterSearchUpdated {
		static void Postfix(ContainerInteraction __instance) {
			if (__instance.m_Container.m_Items.Count == 0 && FasterSearchingSettings.Instance.instantlySearchEmpty) {
				__instance.HoldTime = 0;
			} else {
				__instance.HoldTime *= FasterSearchingSettings.Instance.searchTimeMultiplier;
			}
		}
	}
}
