﻿using System;

namespace NNX.Core.Utils
{
    public static class RandomProvider
    {
        public static Func<int, IRandomGenerator> GetRandom = GetDefaultRandom;
        public static IRandomGenerator GetDefaultRandom(int seed) => new RandomGenerator {Seed = seed};
    }
}
