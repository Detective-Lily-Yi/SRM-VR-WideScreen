using HarmonyLib;
using InfiniteLoop.SRM.Common;
using UnityEngine;

namespace SRMVRWideScreen.Patches
{
    [HarmonyPatch(typeof(CanvasWorldTransform), "Awake")]
    public class CanvasWorldTransformPatch
    {
        private static void Postfix(CanvasWorldTransform __instance)
        {
            var letterBox = __instance.transform.Find("LetterBox");

            if (letterBox != null)
            {
                letterBox.localScale = Vector3.zero;
            }
        }
    }
}