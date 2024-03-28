using HarmonyLib;
using System;

namespace ForceSafetyMode
{
    [HarmonyPatch(typeof(GorillaNetworking.PlayFabAuthenticator), "GetSafety")]
    static class SafetyPatcher
    {
        static bool Prefix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}
