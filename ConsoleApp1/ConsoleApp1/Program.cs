﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(5, 225);
            s1.Display();

            Student s2 = new Student(6, 100);

            Student s3 = s1 + s2;
            s3.Display();

            Student s4 = s1 + 5;
            s4.Display();

            if (s1 < s2)
            {
                Console.WriteLine("s1 < s2");
            }
            else
            {
                Console.WriteLine("s1 > s2");
            }

            int x = s1.id;
            Console.WriteLine(x);

        }
    }
}
