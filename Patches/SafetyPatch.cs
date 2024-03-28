using HarmonyLib;
using System;

namespace ForceSafetyMode
{
    [HarmonyPatch(typeof(GorillaNetworking.PlayFabAuthenticator), "GetSafety")]
    static class SafetyPatcher
    {
        static bool Prefix(ref bool __result)
        {
            SafetyMode.Log.LogInfo("Something is checking if this is a safety account. Telling it that it is.");
            __result = true;
            return false;
        }
    }
}
