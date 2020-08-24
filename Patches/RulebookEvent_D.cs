using Kingmaker.RuleSystem;
using KingmakerLessRandom.Bucket;
using System;

namespace KingmakerLessRandom.Patches
{
    class RulebookEvent_D
    {
        
        [HarmonyLib.HarmonyPatch(typeof(RulebookEvent.Dice), "D")]
        [HarmonyLib.HarmonyPatch(new Type[] { typeof(int), typeof(DiceType) })]

        static class RulebookEvent_D_Patch
        {
            static bool Prefix(ref int __result, int rolls, DiceType dice)
            {
                switch (dice)
                {
                    case DiceType.Zero:
                        __result = 0;
                        break;
                    case DiceType.One:
                        __result = 1;
                        break;
                    case DiceType.D2:
                        __result = BucketWrapper.D2.Result(rolls);
                        break;
                    case DiceType.D3:
                        __result = BucketWrapper.D3.Result(rolls);
                        break;
                    case DiceType.D4:
                        __result = BucketWrapper.D4.Result(rolls);
                        break;
                    case DiceType.D6:
                        __result = BucketWrapper.D6.Result(rolls);
                        break;
                    case DiceType.D8:
                        __result = BucketWrapper.D8.Result(rolls);
                        break;
                    case DiceType.D10:
                        __result = BucketWrapper.D10.Result(rolls);
                        break;
                    case DiceType.D12:
                        __result = BucketWrapper.D12.Result(rolls);
                        break;
                    case DiceType.D20:
                        __result = BucketWrapper.D20.Result(rolls);
                        break;
                    case DiceType.D100:
                        __result = BucketWrapper.D100.Result(rolls);
                        break;
                }
                return false;
            }
        }
    } 
}
