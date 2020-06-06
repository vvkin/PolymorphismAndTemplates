using System;

namespace LAB_6_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program testing:\n");
            try
            {
                ManyVariablesFunction func1 = new TwoVariablesFunction(new double[] { 5, 5 });
                Console.WriteLine("Two variables function result:");
                Console.WriteLine(func1.Calculate());
                ManyVariablesFunction func2 = new ThreeVariablesFunction(new double[] { 5, 5, 5 });
                Console.WriteLine("Three variables function result:");
                Console.WriteLine(func2.Calculate());
                Console.WriteLine("Change variables in two variables function:");
                func1.SetVariables(new double[] { 1, 2 });
                Console.WriteLine(func1.Calculate());
                Console.WriteLine("Change variables in three variables function:");
                func2.SetVariables(new double[] { 1, 2, 3 });
                Console.WriteLine(func2.Calculate());
                Console.WriteLine("Try to set incorrect number of parameters: ");
                ManyVariablesFunction func3 = new TwoVariablesFunction(new double[] { 1 });
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Made by Vadym Kinchur, variant 11, level Б, IP-91");
            }
        }
    }
}
