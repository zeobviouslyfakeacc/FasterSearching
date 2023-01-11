using HarmonyLib;
using Il2Cpp;

namespace FasterSearching {

	[HarmonyPatch(typeof(Container), "BeginContainerOpen")]
	internal static class PatchFasterSearchUpdated {
		static void Prefix(Container __instance) {
			ContainerInteraction interaction = __instance.GetComponent<ContainerInteraction>();
			if (interaction == null) return;

			if (__instance.IsInspected()) {
				interaction.HoldTime *= FasterSearchingSettings.Instance.openTimeMultiplier;
			} else {
				if (__instance.m_GearToInstantiate.Count == 0 && FasterSearchingSettings.Instance.instantlySearchEmpty) {
					interaction.HoldTime = 0;
				} else {
					interaction.HoldTime *= FasterSearchingSettings.Instance.searchTimeMultiplier;
				}
			}
		}
	}
}
