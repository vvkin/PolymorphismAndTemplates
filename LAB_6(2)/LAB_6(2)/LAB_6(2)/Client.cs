using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_6_2_
{
    class Client
    {
        private static string[] names = new string[]
        {
            "Mykola", "Sergiy", "Denys", "Dmytro", "Vadym",
            "Vladyslav", "Bohdan", "Andriy", "Eduard", "Gennadii"
        };
        private int experience;
        private double dangerous;
        private double moneyAmount;
        private double startMoney;
        private int buys;
        private string name;
        private List<Car> cars;

        public Client(int experience, double dangerous, double moneyAmount, string name)
        {
            this.experience = experience;
            this.dangerous = dangerous;
            this.moneyAmount = moneyAmount;
            this.startMoney = moneyAmount;
            this.buys = 0;
            this.name = name;
            cars = new List<Car>();
        }

        public void PayFor(Car car, double newCost)
        {
            moneyAmount -= newCost;
            cars.Add(Car.GetNewCarWithCost(car, newCost));
            ++buys;
        }

        public bool IsCapableToPay(double cost)
        {
            return (moneyAmount >= Choice.leastCost) &&
                   (moneyAmount >= cost);
        }

        public static Client GetRandomClient()
        {
            var rd = new Random(Guid.NewGuid().GetHashCode());
            var experience = rd.Next(0, 35); // years of experience
            var dangerous = rd.NextDouble() / 2;
            var moneyAmount = rd.NextDouble() * (1e6);
            var name = names[rd.Next(names.Length)];
            return (new Client(experience, dangerous, moneyAmount, name));
        }

        public Choice MakeChoice()
        {
            return (Choice.GetRandomChoice(moneyAmount));
        }


        public double CalculateCost(double realCost)
        {
            var newCost = realCost - (realCost * experience / 100);
            newCost += (dangerous / 3 + 1) * realCost;
            if (buys > 2) newCost -= newCost * (0.15);
            return newCost;
        }

        public override string ToString()
        {
            return $"Name: {name}\n" +
                   $"Years of experience {experience}\n" +
                   $"Spent money: {Math.Round(startMoney - moneyAmount, 3)}$\n" +
                   $"Danger factor: {Math.Round(dangerous * 100, 2)}%\n" +
                   $"Rented {buys} cars\n" +
                   $"Money left: {Math.Round(moneyAmount, 3)}$";
        }

        public void PrintRentedCars()
        {
            Console.WriteLine("Rented cars by client: ");
            if (cars.Count  == 0)
            {
                Console.WriteLine("{ }");
            }
            foreach(var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
        }
    }
}
