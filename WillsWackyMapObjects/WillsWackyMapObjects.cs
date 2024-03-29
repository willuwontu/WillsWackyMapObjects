﻿using System;
using System.Reflection;
using BepInEx;
using HarmonyLib;
using MapsExt;
using UnboundLib;
using UnityEngine;
using Jotunn.Utils;

namespace WWMO
{
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInDependency("pykess.rounds.plugins.moddingutils")]
    [BepInDependency("io.olavim.rounds.mapsextended")]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class WillsWackyMapObjects : BaseUnityPlugin
    {
        private const string ModId = "com.willuwontu.rounds.MapObjects";
        private const string ModName = "Will's Wacky Map Objects";
        public const string Version = "1.2.4"; // What version are we on (major.minor.patch)?

        public static WillsWackyMapObjects instance { get; private set; }

        public AssetBundle MapObjectAssets;

        internal static readonly Material defaultMaterial = new Material(Shader.Find("Sprites/Default"));

        void Awake()
        {
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }

        void Start()
        {
            Unbound.RegisterCredits(ModName, new string[] { "willuwontu" }, new string[] { "github", "Ko-Fi" }, new string[] { "https://github.com/willuwontu/WillsWackyMapObjects", "https://ko-fi.com/willuwontu" });

            instance = this;

            MapObjectAssets = AssetUtils.LoadAssetBundleFromResources("wwmo", typeof(WillsWackyMapObjects).Assembly);
        }
    }
}
