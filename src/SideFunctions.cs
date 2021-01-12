using UnityEngine;
using System;

namespace FurClothing
{
    static class GearFunctions
    {
        public static void changePostfabParameters(GearItem instance, float warmth, float wetwarmth, float windproof, float protection, float weight)
        {
            instance.m_ClothingItem.m_Warmth = warmth;
            instance.m_ClothingItem.m_WarmthWhenWet = wetwarmth;
            instance.m_ClothingItem.m_Windproof = windproof;
            instance.m_ClothingItem.m_Toughness = protection;
            instance.m_WeightKG = weight;
        }
        public static void changePrefabParameters(string name, float warmth, float wetwarmth, float windproof, float protection, float weight)
        {
            GearItem item = GetGearItemPrefab(name);
            item.m_ClothingItem.m_Warmth = warmth;
            item.m_ClothingItem.m_WarmthWhenWet = wetwarmth;
            item.m_ClothingItem.m_Windproof = windproof;
            item.m_ClothingItem.m_Toughness = protection;
            item.m_WeightKG = weight;
        }
        private static GearItem GetGearItemPrefab(string name) => Resources.Load(name).Cast<GameObject>().GetComponent<GearItem>();
    }
}