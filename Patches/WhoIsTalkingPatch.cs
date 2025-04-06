using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;
using WhoIsTalking;
namespace WhatIsTheFPS.Patches
{
    [HarmonyPatch(typeof(NameTagHandler))]
    [HarmonyPatch("GetInfo", MethodType.Normal)]
    internal class WhoIsTalkingPatch0
    {
        private static void Postfix(NameTagHandler __instance)
        {
            __instance.GetOrAddComponent<FPSHandler>(out var NTH);
            NTH.nameTagHandler = __instance;
        }
    }
}