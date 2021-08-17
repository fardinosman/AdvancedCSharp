using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLamdaExpression
{

    
    class Program
    {
        //delegate void MyDel(String s);

        delegate string MyDel(string s);

        delegate int CountIt(int x);

        static void Main(string[] args)
        {
            //delegates signature
            //MyDel del = new MyDel(TestFunction);

            //MyDel del = TestFunction;
            //del("Hello World");

            //MyDel del = TestFunction;
            //for (int i = 0; i < 10; i++)
            //{
            //    del += TestFunction;
            //   // del("Hello WOrld");
            //}

            //del("Hello WOrld");

            MyDel del = TestFunction;
            del += TestFunction2;

            string result = del("d");

            Console.WriteLine(result);

            CountIt countIt = delegate(int x)//ananoumus method
            {
                int total = 0;
                for (int i = 0; i < 5; i++)
                {
                    total += x;
                   // Console.WriteLine(i);
                }
                return total;
            };
            int overtotal = countIt(100);
            Console.WriteLine(overtotal);

            CountIt countIt1 = (int x) => x + 5;
            //statement lamda expression
            //CountIt countIt1 = (int x) =>
            //{
            //    x + 5;
 
            //}

            int resu = countIt1(5);
            Console.WriteLine(resu);

            Person p = new Person();
            //this makes us a subscriber
            p.CashEvent += P_CashEvent;
            p.AddCash(50);
            p.AddCash(50);
        }

        private static void P_CashEvent()
        {
            Console.WriteLine("Person has gain a 100 dollars");
        }

        //static void TestFunc()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //static  void TestFunction(string text)
        //{
        //    Console.WriteLine(text);
        //}
        static string TestFunction(string s)
        {
            return "Hello World";
        }
        static string TestFunction2(string s)
        {
            return "Bye World";
        }
    }

    class Animal
    {

    }
    class Dog :Animal 
    {

    }

    class Person
    {
        public delegate void MyEventHandler();
        public event MyEventHandler CashEvent;

        private int cash;
        public int Cash
        {
            get
            {
                return cash;
            }
            set
            {
                cash = value;
                if (cash >=100)
                {
                    //let or subscriber know or notyfy them
                    if (CashEvent != null)
                    {
                        CashEvent();
                    }
                }
            }
        }
        
        public void AddCash(int amount)
        {
            Cash += amount;
        }
    }
}
