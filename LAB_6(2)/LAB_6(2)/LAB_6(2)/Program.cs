using System;

namespace LAB_6_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int clientsNumber, carsNumber, repetitions;
            Console.WriteLine("Type the number of clients: ");
            clientsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the number of cars: ");
            carsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the number of customer requests");
            repetitions = int.Parse(Console.ReadLine());

            Console.WriteLine("Collection of shop objects: ");
            TemplateCollection<Shop> collection1 = new TemplateCollection<Shop>();
            collection1.Add(new Shop(carsNumber, clientsNumber));
            collection1[0].ProcessShop(repetitions);
            Console.WriteLine(collection1[0]);

            Console.WriteLine("Collection of client objects:\n");
            TemplateCollection<Client> collection2 = new TemplateCollection<Client>();
            collection2.Add(Client.GetRandomClient());
            collection2.Add(Client.GetRandomClient());
            collection2.Add(Client.GetRandomClient());
            for(var i = 0; i < collection2.Count; ++i)
            {
                Console.WriteLine($"{collection2[i]}\n");
            }

            Console.WriteLine("\nMade by Vadym Kinchur, variant 11, level В, IP-91");
        }
    }
}
