using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LAB_6_2_
{
    class Car
    {
        private int type; // 0 - 10
        private double cost; // 10K - 10M
        private string color; //1-6
        private double mass; // 500 - 20К

        private static int carsNumber = 0;
        private static int typesNumber = 10;

        private static string[] marks = new string[]
        {
            "Toyota", "Audi", "BMW", "Aston Martin",
            "Ford", "Citroen", "Honda", "Lamborghini",
            "Porsche", "Tesla"
        };
       
        public Car(int type, double cost, string color, double mass)
        {
            this.type = type;
            this.cost = cost;
            this.color = color;
            this.mass = mass;
            ++carsNumber;
        }

        public static Car GetNewCarWithCost(Car car, double cost)
        {
            return new Car(car.type, cost, car.color, car.mass);
        }

        
        public static Car GetRandomCar()
        {
            var rd = new Random(Guid.NewGuid().GetHashCode());
            var type = rd.Next(typesNumber);
            var cost = rd.Next(Choice.leastCost, Choice.highestCost);
            var color = Color.GetRandomColor();
            var mass = rd.NextDouble() * Choice.highestMass + Choice.leastMass;
            return (new Car(type, cost, color, mass));
        }

        public static int GetTypesNumber()
        {
            return typesNumber;
        }

        public static int GetCarsNumber()
        {
            return carsNumber;
        }

        public double GetCost()
        {
            return cost;
        }

        public bool IsSuitable(Choice choice)
        {
            return (cost >= choice.lowerMoneyBound && cost <= choice.higherMoneyBound) &&
                   (mass >= choice.lowerMassBound && mass <= choice.higherMassBound) &&
                   (choice.possibleColors.Contains(color) && type == choice.type);
        }

        public new int GetType()
        {
            return type;
        }

        public static string GetMarkByType(int type)
        {
            return (marks[type]);
        }

        public override string ToString()
        {
            return $"{marks[type]}, color {color}, cost {Math.Round(cost, 3)}$";
        }
    }
}
