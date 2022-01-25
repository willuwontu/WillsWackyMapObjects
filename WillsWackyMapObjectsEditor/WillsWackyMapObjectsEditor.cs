using System;
using System.Reflection;
using BepInEx;
using HarmonyLib;
using MapsExt;
using UnboundLib;

namespace WWMOE
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.willuwontu.rounds.managers", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class WillsWackyMapObjectsEditor : BaseUnityPlugin
    {
        private const string ModId = "com.willuwontu.rounds.MapObjects";
        private const string ModName = "Will's Wacky Map Objects";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?

        public static WillsWackyMapObjectsEditor instance { get; private set; }

        void Awake()
        {
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }

        void Start()
        {
            Unbound.RegisterCredits(ModName, new string[] { "willuwontu" }, new string[] { "github", "Ko-Fi" }, new string[] { "https://github.com/willuwontu/wills-wacky-cards", "https://ko-fi.com/willuwontu" });

            instance = this;

            var assembly = Assembly.GetCallingAssembly();
            this.ExecuteAfterSeconds(0.1f, () => { MapsExtended.instance.RegisterMapObjectsAction?.Invoke(assembly); });
        }
    }
}
