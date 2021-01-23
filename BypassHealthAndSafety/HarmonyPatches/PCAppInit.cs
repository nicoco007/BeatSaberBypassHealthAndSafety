using HarmonyLib;

namespace BypassHealthAndSafety.HarmonyPatches
{
    [HarmonyPatch(typeof(PCAppInit), "TransitionToNextScene")]
    internal static class PCAppInit_TransitionToNextScene
    {
        public static bool Prefix(DefaultScenesTransitionsFromInit ____defaultScenesTransitionsFromInit)
        {
            ____defaultScenesTransitionsFromInit.TransitionToNextScene(true);

            return false;
        }
    }
}
