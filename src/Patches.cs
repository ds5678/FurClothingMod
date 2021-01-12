using System;
using Harmony;
using UnhollowerBaseLib;
using UnityEngine;

namespace FurClothing
{
    internal static class Patches
    {
        private const string RABBIT_HAT_NAME = "GEAR_RabbitskinHat";
        private const string BEAR_COAT_NAME = "GEAR_BearSkinCoat";
        private const string WOLF_COAT_NAME = "GEAR_WolfSkinCape";
        private const string MOOSE_COAT_NAME = "GEAR_MooseHideCloak";
        private const string RABBIT_MITTS_NAME = "GEAR_RabbitSkinMittens";
        private const string DEER_PANTS_NAME = "GEAR_DeerSkinPants";
        private const string DEER_BOOTS_NAME = "GEAR_DeerSkinBoots";
        

        [HarmonyPatch(typeof(GameManager), "Update")]
        private static class ChangePrefabs
        {
            internal static void Postfix()
            {
                GearFunctions.changePrefabParameters(RABBIT_HAT_NAME,
                                                    Settings.options.rabbitHatWarmth,
                                                    Settings.options.rabbitHatWetWarmth,
                                                    Settings.options.rabbitHatWindproof,
                                                    Settings.options.rabbitHatProtection,
                                                    Settings.options.rabbitHatWeight);
                GearFunctions.changePrefabParameters(BEAR_COAT_NAME,
                                                    Settings.options.bearCoatWarmth,
                                                    Settings.options.bearCoatWetWarmth,
                                                    Settings.options.bearCoatWindproof,
                                                    Settings.options.bearCoatProtection,
                                                    Settings.options.bearCoatWeight);
                GearFunctions.changePrefabParameters(WOLF_COAT_NAME,
                                                    Settings.options.wolfCoatWarmth,
                                                    Settings.options.wolfCoatWetWarmth,
                                                    Settings.options.wolfCoatWindproof,
                                                    Settings.options.wolfCoatProtection,
                                                    Settings.options.wolfCoatWeight);
                GearFunctions.changePrefabParameters(MOOSE_COAT_NAME,
                                                    Settings.options.mooseCoatWarmth,
                                                    Settings.options.mooseCoatWetWarmth,
                                                    Settings.options.mooseCoatWindproof,
                                                    Settings.options.mooseCoatProtection,
                                                    Settings.options.mooseCoatWeight);
                GearFunctions.changePrefabParameters(RABBIT_MITTS_NAME,
                                                    Settings.options.rabbitMittsWarmth,
                                                    Settings.options.rabbitMittsWarmth,
                                                    Settings.options.rabbitMittsWindproof,
                                                    Settings.options.rabbitMittsProtection,
                                                    Settings.options.rabbitMittsWeight);
                GearFunctions.changePrefabParameters(DEER_PANTS_NAME,
                                                    Settings.options.deerPantsWarmth,
                                                    Settings.options.deerPantsWetWarmth,
                                                    Settings.options.deerPantsWindproof,
                                                    Settings.options.deerPantsProtection,
                                                    Settings.options.deerPantsWeight);
                GearFunctions.changePrefabParameters(DEER_BOOTS_NAME,
                                                    Settings.options.deerBootsWarmth,
                                                    Settings.options.deerBootsWetWarmth,
                                                    Settings.options.deerBootsWindproof,
                                                    Settings.options.deerBootsProtection,
                                                    Settings.options.deerBootsWeight);

            }
        }

        [HarmonyPatch(typeof(GearItem),"ManualUpdate")]
        private static class ChangeIngameItems
        {
            internal static void Postfix(GearItem __instance)
            {
                if (__instance.name == RABBIT_HAT_NAME)
                {
                    GearFunctions.changePostfabParameters(__instance,
                                                       Settings.options.rabbitHatWarmth,
                                                       Settings.options.rabbitHatWetWarmth,
                                                       Settings.options.rabbitHatWindproof,
                                                       Settings.options.rabbitHatProtection,
                                                       Settings.options.rabbitHatWeight);
                }
                if (__instance.name == BEAR_COAT_NAME)
                {
                    GearFunctions.changePostfabParameters(__instance,
                                                        Settings.options.bearCoatWarmth,
                                                        Settings.options.bearCoatWetWarmth,
                                                        Settings.options.bearCoatWindproof,
                                                        Settings.options.bearCoatProtection,
                                                        Settings.options.bearCoatWeight);
                }
                if (__instance.name == WOLF_COAT_NAME)
                {
                    GearFunctions.changePostfabParameters(__instance,
                                                        Settings.options.wolfCoatWarmth,
                                                        Settings.options.wolfCoatWetWarmth,
                                                        Settings.options.wolfCoatWindproof,
                                                        Settings.options.wolfCoatProtection,
                                                        Settings.options.wolfCoatWeight);
                }
                if (__instance.name == MOOSE_COAT_NAME)
                {
                    GearFunctions.changePostfabParameters(__instance,
                                                        Settings.options.mooseCoatWarmth,
                                                        Settings.options.mooseCoatWetWarmth,
                                                        Settings.options.mooseCoatWindproof,
                                                        Settings.options.mooseCoatProtection,
                                                        Settings.options.mooseCoatWeight);
                }
                if (__instance.name == RABBIT_MITTS_NAME)
                {
                    GearFunctions.changePostfabParameters(__instance,
                                                        Settings.options.rabbitMittsWarmth,
                                                        Settings.options.rabbitMittsWarmth,
                                                        Settings.options.rabbitMittsWindproof,
                                                        Settings.options.rabbitMittsProtection,
                                                        Settings.options.rabbitMittsWeight);
                }
                if (__instance.name == DEER_PANTS_NAME)
                {
                    GearFunctions.changePostfabParameters(__instance,
                                                        Settings.options.deerPantsWarmth,
                                                        Settings.options.deerPantsWetWarmth,
                                                        Settings.options.deerPantsWindproof,
                                                        Settings.options.deerPantsProtection,
                                                        Settings.options.deerPantsWeight);
                }
                if (__instance.name == DEER_BOOTS_NAME)
                {
                    GearFunctions.changePostfabParameters(__instance,
                                                        Settings.options.deerBootsWarmth,
                                                        Settings.options.deerBootsWetWarmth,
                                                        Settings.options.deerBootsWindproof,
                                                        Settings.options.deerBootsProtection,
                                                        Settings.options.deerBootsWeight);
                }
            }
        }
    }
}