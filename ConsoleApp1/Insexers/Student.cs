using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insexers
{
    public class Student
    {
        public string Name { get; set; }

        public int Id { get; set; }

        private int[] myScores;

        public Student(string n, int i)
        {
            Name = n;
            Id = i;

            myScores = new int[3];
            myScores[0] = 65;
            myScores[1] = 75;
            myScores[2] = 85;
        }
        public void Show()
        {
            for (int i = 0; i < myScores.Length; i++)
            {
                Console.WriteLine(myScores[i]);
            }
        }
        public int this[int index]
        {
            get
            {
                if (index >=0 && index <this.myScores.Length )
                {
                    return this.myScores[index];
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (index >= 0 && index < this.myScores.Length)
                {
                    this.myScores[index] = value;
                }
               
            }
        
        }
    }
}
