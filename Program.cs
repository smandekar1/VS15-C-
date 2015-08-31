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
            int a = 45;
            int b = 34;

            Console.WriteLine("1. Add 2.  Sub 3.  Mul 4.  Div ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {

                case 1:
                    Console.WriteLine(a + b);
                    break;

                case 2:
                    Console.WriteLine(a - b);
                    break;


                case 3:
                    Console.WriteLine(a * b);
                    break;


                case 4:
                    Console.WriteLine((double)a / b);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.ReadLine();

        }
    }
}
