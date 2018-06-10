using Harmony;

namespace FasterSearching
{
    [HarmonyPatch(typeof(Container))]
    [HarmonyPatch("BeginContainerInteraction")]
    class PatchFasterSearch
    {
        static void Prefix(ref float searchTimeSeconds, ref Container __instance)
        {
            if (__instance.m_Items.Count == 0)
            {
                searchTimeSeconds = 0f;
            }
            else
            {
                searchTimeSeconds *= 0.3f;
            }
        }
    }
}