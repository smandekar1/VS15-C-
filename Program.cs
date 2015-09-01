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
            //int[] a;
            //A = new int[5];


            int[] A = new int[5];

            Console.WriteLine("Enter 5 Element");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Eleements that you entered are : ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }

            Array.Sort(A);
            Array.Reverse(A);
            

            Console.WriteLine("Eleements that you sorted are : ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }

            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum = sum + A[i];
            }
            Console.WriteLine("Sum is "+sum);

            //foreach(int k in A)
            //{
            //    if(k%2==0)
            //    Console.WriteLine(k);
            //}

            Console.ReadLine();
        }
    }
}

