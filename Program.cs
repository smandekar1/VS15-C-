using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Customer
    {
        int AcNo;
        string Name;
        double Bal;
        string Contact;


        public Customer()
        {
            Console.WriteLine("Hello Wolrd");
        }


        public Customer(int AcNo, string Name, double Bal):this()
        {
            this.AcNo = AcNo;
            this.Name = Name;
            this.Bal = Bal;
           

        }


        public Customer(int AcNo, string Name, double Bal, string Contact) : this(AcNo, Name, Bal)
        {
            //this.AcNo = AcNo;
            //this.Name = Name;
            //this.Bal = Bal;
            this.Contact = Contact;

        }

        public void Deposit(double amt)
        {
            Bal = Bal + amt;
        }

        public void Withdraw(double amt)
        {
            Bal = Bal - amt;
        }



        public void BalEnq()
        {
            Console.WriteLine("AcNo:{0}Name:{1} Bal: {2} Contact: {3}", AcNo, Name, Bal, Contact);
        }

        public void BalEnq(double amt, string f)
        {
            if(f=="D")
            {
                Bal += amt;
            }
            else if(f=="W")
            {
                Bal -= amt;

            }
            else
            {
                Console.WriteLine("Invalid Flag");
            }
            Console.WriteLine("AcNo:{0}Name:{1} Bal: {2} Contact: {3}", AcNo, Name, Bal, Contact);

        }

    }
        
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(1234,"Jack", 78000, "9898565");


            //c.CreateCustomer(1234, "Jack", 78000);

            //c.BalEnq();

            //c.CreateCustomer(1234, "Jack", 78000);

            c.BalEnq();

            Customer c1 = new Customer(123, "Peter", 89000);

            c1.BalEnq();


            Console.ReadLine();
        }
    }
}

