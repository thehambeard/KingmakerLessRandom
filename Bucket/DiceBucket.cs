using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace KingmakerLessRandom.Bucket
{
    public class DiceBucket
    {
        public int Sides { get; private set; }
        public int Population { get; set; }
        public int DiceLeft { get; private set; }

        private List<int> bucket = new List<int>();
        private Random rng = new Random();

        public DiceBucket(int sides, int population)
        {
            //Main.Mod.Debug(MethodBase.GetCurrentMethod());
            Sides = sides;
            Population = population;
            Fill();
        }
        public void Fill()
        {
            //Main.Mod.Debug(MethodBase.GetCurrentMethod());
            DiceLeft = Population * Sides;
            bucket.Clear();
            bucket.AddRange(Enumerable.Range(1, Sides).ToList());
            bucket.Shuffle(rng);
        }

        public int Result()
        {
            //Main.Mod.Debug(MethodBase.GetCurrentMethod());
            if (DiceLeft <= 0) Fill();
            return (bucket[--DiceLeft]);
        }

        public int Result(int rolls)
        {
            //Main.Mod.Debug(MethodBase.GetCurrentMethod());
            int total = 0;
            while (rolls-- > 0)
            {
                total += Result();
            }
            return total;
        }
    }
    internal static class Extensions
    {
        public static void Shuffle<T>(this List<T> list, Random rng)
        {
            //Main.Mod.Debug(MethodBase.GetCurrentMethod());
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
