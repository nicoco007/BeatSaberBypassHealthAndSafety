using HarmonyLib;
using IPA;
using System.Reflection;

namespace BypassHealthAndSafety
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        private const string kHarmonyId = "com.nicoco007.bypass-health-and-safety";

        private readonly Harmony _harmony;

        [Init]
        public Plugin()
        {
            _harmony = new Harmony(kHarmonyId);
        }

        [OnEnable]
        public void OnEnable()
        {
            _harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        [OnDisable]
        public void OnDisable()
        {
            _harmony.UnpatchAll(kHarmonyId);
        }
    }
}
