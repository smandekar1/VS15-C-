using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamB.GroupA;

//namespace TeamA
//{

//    class Student
//    {
//        public void Display()
//        {

//        }
//    }
//}
namespace TeamB
{
    class Student
    {
        public void Show()
        {

        }
    }

    class Teacher
    {
        public void GetSalary()
        {

        }
    }

    namespace GroupA
    {
        class Test
        {
            public void Go()
            {
                Console.WriteLine("This is a go method ");
            }
        }
    }

    namespace MyFirstApp
    {
        class Program
        {

            static void Main(string[] args)
            {
                //TeamA.Student s = new TeamA.Student();
                //TeamB.Student s1 = new TeamB.Student();
                //s.Display();
                //s1.Show();

                //TeamB.GroupA.Test t = new TeamB.GroupA.Test();

                Test t = new Test();
                t.Go();
                Console.ReadLine();


            }
        }
    }
}

