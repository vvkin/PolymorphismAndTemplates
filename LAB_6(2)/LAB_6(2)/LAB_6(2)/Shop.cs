using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_6_2_
{
    class Shop 
    {
        private List<Car> cars;
        private List<Client> clients;
        private double[] moneyByType;
        private int[] buysByType;

        public Shop(int carsNumber, int cliensNumber)
        {
            cars = new List<Car>();
            clients = new List<Client>();
            for(var i = 0; i < carsNumber; ++i)
            {
                cars.Add(Car.GetRandomCar());
            }
            for(var i = 0; i < cliensNumber; ++i)
            {
                clients.Add(Client.GetRandomClient());
            }
            moneyByType = new double[Car.GetTypesNumber()];
            buysByType = new int[Car.GetTypesNumber()];
        }

        public void ProcessShop(int repetitions)
        {
            var rd = new Random();
            for (var i = 0; i < repetitions; ++i)
            {
                var currClinent = clients[rd.Next(clients.Count)];
                if (!currClinent.IsCapableToPay(0)) continue;
                var choice = currClinent.MakeChoice();
                var currCars = SuitableCars(choice);
                if (currCars.Count < 1) continue;
                var choosenCar = currCars[rd.Next(currCars.Count)];
                var newCost = currClinent.CalculateCost(choosenCar.GetCost());
                if (!currClinent.IsCapableToPay(newCost)) continue;
                currClinent.PayFor(choosenCar, newCost);
                AddCarToHistory(choosenCar, newCost);
            }
        }

        private List<Car> SuitableCars(Choice choice)
        {
            var suitableCars = new List<Car>();
            foreach(var car in cars)
            {
               if (car.IsSuitable(choice))
               {
                    suitableCars.Add(car);
               }
            }
            return suitableCars;
        }

        private void AddCarToHistory(Car car, double newCost)
        {
            var carType = car.GetType();
            ++buysByType[carType];
            moneyByType[carType] += newCost;
        }

        private void PrintSoldInfo()
        {
            Console.WriteLine("//=======================================\\\\");
            Console.WriteLine("Sold info: \n");
            for(var i = 0; i < buysByType.Length; ++i)
            {
                Console.WriteLine($"Sold in total {buysByType[i]} cars type {Car.GetMarkByType(i)}");
                Console.WriteLine($"Total earned by this type: {Math.Round(moneyByType[i], 3)}$\n");
            }
            Console.WriteLine("//=======================================\\\\\n");
        }

        private void PrintClientsInfo()
        {
            Console.WriteLine("Info about clients: ");
            Console.WriteLine($"Total number of clients is equal to {clients.Count}");
            Console.WriteLine("Info about each client: \n");
            foreach(var client in clients)
            {
                Console.WriteLine(client);
                client.PrintRentedCars();
            }
        }

        public override string ToString()
        {
            PrintSoldInfo();
            PrintClientsInfo();
            return "";
        }
    }
}
