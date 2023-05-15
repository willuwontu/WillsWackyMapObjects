using System;
using System.Reflection;
using BepInEx;
using HarmonyLib;
using MapsExt;
using UnboundLib;

namespace WWMOE
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class WillsWackyMapObjectsEditor : BaseUnityPlugin
    {
        private const string ModId = "com.willuwontu.rounds.MapObjectsEditor";
        private const string ModName = "Will's Wacky Map Objects Editor";
        public const string Version = "1.1.6"; // What version are we on (major.minor.patch)?

        public static WillsWackyMapObjectsEditor instance { get; private set; }

        void Awake()
        {
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }

        void Start()
        {
            Unbound.RegisterCredits(ModName, new string[] { "willuwontu" }, new string[] { "github", "Ko-Fi" }, new string[] { "https://github.com/willuwontu/WillsWackyMapObjects", "https://ko-fi.com/willuwontu" });

            instance = this;
        }
    }
}
