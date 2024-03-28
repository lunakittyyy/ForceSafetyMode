using BepInEx;
using BepInEx.Logging;

namespace ForceSafetyMode
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class SafetyMode : BaseUnityPlugin
    {
        internal static ManualLogSource Log;

        public void Start()
        {
            Log = base.Logger;
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }
}