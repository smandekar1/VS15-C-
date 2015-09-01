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
            int n;
            do{ 
                n = int.Parse(Console.ReadLine());
            }
            while (n!= 0);

            Console.WriteLine("You have entered " + n);
 

        }
    }
}

