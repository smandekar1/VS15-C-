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
            int[] A;
            A = new int[10];

            A[0] = 67;
            A[1] = A[2] = A[3] = 56;
            A[4] = A[1] + A[2] + A[3];
            A[5] = A[6] = A[7] = A[4] - 10;
            A[8] = A[9] = int.Parse(Console.ReadLine());

            for(int i=0; i<10; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.ReadLine();

        }
    }
}

