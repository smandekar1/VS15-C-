using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Manzoor");
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }

            int n = 6;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
            }
            Console.ReadLine();

        }
    }
}
