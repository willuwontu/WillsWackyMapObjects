using BepInEx;
using HarmonyLib;

namespace ExtraMapObjects
{
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInDependency("com.willuwontu.rounds.MapObjects")]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class ExtraMapObjectsEditor : BaseUnityPlugin
    {
        private const string ModId = "com.bosssloth.rounds.ExtraMapObjectsEditor";
        private const string ModName = "ExtraMapObjectsEditor";
        public const string Version = ExtraMapObjects.Version;

        public static ExtraMapObjectsEditor instance { get; private set; }

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
