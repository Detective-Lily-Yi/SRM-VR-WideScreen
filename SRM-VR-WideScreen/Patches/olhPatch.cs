using HarmonyLib;
using UnityEngine;

namespace SRMVRWideScreen.Patches
{
    //BA 38 04 00 00 B9 80 07 00 00
    [HarmonyPatch(typeof(brw), "oob")]
    public class olhPatch
    {
        private static void Postfix()
        {
            var currentResolution = Screen.currentResolution;

            Screen.SetResolution(currentResolution.width, currentResolution.height, Screen.fullScreenMode);
        }
    }
}