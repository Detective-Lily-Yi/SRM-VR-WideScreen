using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace SRMVRWideScreen
{
    [BepInPlugin("com.Detective-Lily-Yi.SRM-VR-WideScreen", "SRM-VR-WideScreen", "1.0.0")]
    public class SRMVRWideScreenPlugin : BasePlugin
    {
        public override void Load()
        {
            Harmony.CreateAndPatchAll(typeof(SRMVRWideScreenPlugin).Assembly);
        }
    }
}