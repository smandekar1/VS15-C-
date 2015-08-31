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

            Console.WriteLine("+. Add -.  Sub *.  Mul /.  Div ");
            string ch = (Console.ReadLine());

            switch (ch)
            {

                case "+":
                    Console.WriteLine(a + b);
                    break;

                case "-":
                    Console.WriteLine(a - b);
                    break;


                case "*":
                    Console.WriteLine(a * b);
                    break;


                case "/":
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
