using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int id;
        public double grade;

        public Student(int id, double grade)
        {
            this.id = id;
            this.grade = grade;
        }

        public void Display()
        {
            Console.WriteLine("ID: " +id);
            Console.WriteLine("Grade: "+ grade);
        }
        public static Student operator +(Student s1, Student s2)
        {
            Student newStudent = new Student(s1.id + s2.id, s1.grade + s2.grade);
            return newStudent;
        }
        public static Student operator +(Student s1, int x)
        {
            Student newStudent = new Student(s1.id + x, s1.grade + x);
            return newStudent;
        }
        public static bool operator <(Student s1, Student s2)
        {
            if (s1.grade < s2.grade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Student s1, Student s2)
        {
            if (s1.grade > s2.grade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static implicit operator int(Student s1)
        {
            return s1.id;
        }
    }
}
