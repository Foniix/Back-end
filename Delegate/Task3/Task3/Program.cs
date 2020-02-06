using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    internal class Program
    {
        private delegate int Rnd();
        private static int MyRandom()
        {
            var rand = new Random();
            return rand.Next(10);
        }

        private static void Main(string[] args)
        {
            static double AvarageDelegate(IReadOnlyCollection<Rnd> r)
            {
                var sum = r.Sum(t => t.Invoke());

                return sum / r.Count;
            }
            Console.WriteLine($"\nResult {AvarageDelegate(new Rnd[3] { MyRandom, MyRandom, MyRandom })} ");
            Console.ReadKey();
        }

    }
}
