using BepInEx;
using HarmonyLib;

namespace ExtraMapObjects
{
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInDependency("com.willuwontu.rounds.MapObjects")]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class ExtraMapObjects : BaseUnityPlugin
    {
        private const string ModId = "com.bosssloth.rounds.ExtraMapObjects";
        private const string ModName = "ExtraMapObjects";
        public const string Version = "1.1.1";

        public static ExtraMapObjects instance { get; private set; }

        void Awake()
        {

        }
        void Start()
        {
            instance = this;

            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
    }
}
