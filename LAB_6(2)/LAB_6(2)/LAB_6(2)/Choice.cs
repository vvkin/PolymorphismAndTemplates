using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_6_2_
{
    class Choice
    {
        public string[] possibleColors;
        public int lowerMoneyBound;
        public int higherMoneyBound;
        public int type;
        public int lowerMassBound;
        public int higherMassBound;

        public static int highestCost => (int)1e5;
        public static int leastCost => (int)5e2;
        public static int highestMass => (int)1e4;
        public static int leastMass => (int)5e2;

        public Choice(string[] possibleColors, int lowerMoneyBound, int higherMoneyBound,
                      int type, int lowerMassBound, int higherMassBound)
        {
            this.possibleColors = possibleColors.Clone() as string[];
            this.lowerMoneyBound = lowerMoneyBound;
            this.higherMoneyBound = higherMoneyBound;
            this.lowerMassBound = lowerMassBound;
            this.higherMassBound = higherMassBound;
            this.type = type;
        }

        public static Choice GetRandomChoice(double moneyAmount)
        {
            var rd = new Random(Guid.NewGuid().GetHashCode());
            var possibleColor = Color.GetRandomColorArray();
            var lowerMoneyBound = rd.Next(0, (int)moneyAmount);
            var higherMoneyBound = rd.Next(0, (int)moneyAmount);
            var lowerMassBound = rd.Next(leastMass, highestMass);
            var higherMassBound = rd.Next(lowerMassBound, highestMass);
            var type = rd.Next(Car.GetTypesNumber());
            return (new Choice(possibleColor, lowerMoneyBound, higherMoneyBound, type, lowerMassBound, higherMassBound));
        }
    }
};
