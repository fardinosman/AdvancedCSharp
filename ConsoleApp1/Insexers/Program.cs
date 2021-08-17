using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Far", 50);
            s[2] = 5000;
            s.Show();           
            //List<int> myList = new List<int>();
            //myList.Add(5);
            //myList[5] = 6;
        }
    }
}
