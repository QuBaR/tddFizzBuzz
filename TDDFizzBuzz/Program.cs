using System;

namespace TDDFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzEngine = new FizzBuzzEngine();

            while (fizzBuzzEngine.Value < 100)
            {
                fizzBuzzEngine.Step();
                string fizzBuzzString = fizzBuzzEngine.GetFizzBuzzString();
                Console.Write($"{fizzBuzzString} ");
            }

            Console.ReadLine();
        }
    }
}
