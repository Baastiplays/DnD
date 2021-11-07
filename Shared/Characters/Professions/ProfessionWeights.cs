﻿
namespace DND.Characters.Professions
{
    public static class ProfWeightIDs
    {
        //public static readonly byte Ruralpeasant
    }
    public static class ProfessionWeights
    {
        /*
        public static int[] template = {
              0,  0,  0,  0,  0,    0,  0,  0,  0,  0,    0,  0,  0,  0,  0,     0,  0,  0,  0,  0,
              0,  0,  0,  0,  0,    0,  0,  0,  0,  0,    0,  0,  0,  0,  0,     0,  0,  0,  0,  0,
              0,  0,  0,  0,  0,    0,  0,  0,  0,  0,
        };
        */

        public static int[] RuralPeasant = {
             80,  0,  0,  0,  0,    0,  0,  0, 10,  0,    0,  0,  0,  0,  0,     0,  0,  0,  0,  0,
              0,  0,  0,  0, 20,    0,  0,  0,  0,  0,    0, 15,  0,  0, 10,     0,  20,  0,  0,  0,
              0, 80,100,  0,  0,    0,  0, 50,  0, 30,
        };

        public static int[] RuralLandowner = {
            0,  0,  0,  0,  0,    0,  0,  0, 30,  0,    0,  0,  0,  0,  0,     0,  0,  0,  5,  0,
            0,  0,  0,  0,  0,    0,  5, 10,  0,  5,    0,  0,  0,  0,  0,     0,  0,  0,  0,  0,
            0,  0,  0,  0, 10,    0,  0,  0,  0,  0,
        };

        public static int[] CityPeasant = {
            0,  0, 10, 25,  0,    0,  0,  0,  0,  0,    0, 10,  0, 10,  0,    10,  0,  0,  0,  0,
            0,  0,  0,  0, 30,   20,  0,  0,  5,  0,    0,  5, 10,  0,  0,     0, 70,  0,  0,  0,
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,
        };

        public static int[] CityTradesman = {
            0, 20,  0, 50, 20,    5, 20, 10,  0, 10,   20,  0,  5,  0,  5,     5,  0,  5,  0,  0,
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,    0,  0,  0,  5,  0,     5,  0,  3,  0,  0,
            0,  0,  0,  5, 10,   10, 10,  0,  3,  0,
        };

        public static int[] CityMerchant = {
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,    0,  0,  0,  0,  0,     0,  0, 20,  0, 30,
            0, 20,  0,  0,  0,    0,  0,  0,  0,  0,  100,  0,  0,  0,  0,     0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,
        };

        public static int[] Knight = {
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,    0,  0,  0,  0,  0,     0,  0,  0,  0,  0,
           10,  0,  0,  0,  0,    0,  0,  0,  0,  0,    0,  0,  0,  0,  0,     0,  0,  0,  0,100,
           30,  0,  0,  0,  0,    0,  0,  0,  0,  0,
        };

        public static int[] LowAristocracy = {
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,    0,  0,  0,  0,  0,     0,  0,  0,100,  0,
            0,  0,  0,  0,  0,    0, 10, 10,  0, 30,    0,  0,  0,  0,  0,     0,  0,  0,  5,  0,
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,
        };

        public static int[] HighAristocracy = {
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,    0,  0,  0,  0,  0,     0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,    0,  0, 70,  0, 40,    0,  0,  0,  0,  0,     0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,
        };

        public static int[] Warrior = {
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,    0,  0,  0,  0,  0,     0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,    0,  0,  0,  0,  0,     0,  0,  0,  0, 70,
          100,  0,  0,  0,  0,    0,  0,  0,  0,  0,
        };

        public static int[] Sailor = {
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,    0,  0,  0,  0,  0,     0,  0,  0,  0,  0,
            0,  0,  5,100,  0,    0,  0,  0,  0,  0,    0,  0,  0,  0,  0,     0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,    0,  0,  0,  0,  0,
        };

        public static int[][] ProfessionWeightList =
        {
            RuralPeasant, RuralLandowner, CityPeasant, CityTradesman, CityMerchant,
            Knight, LowAristocracy, HighAristocracy, Warrior, Sailor
        };
    }
}
