using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace De_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(1, "Trung", new DateTime(1990, 11, 10));
            Console.WriteLine("Age of student: " + st.GetAge().ToString());
            Console.WriteLine(st.ToString());
            Console.ReadLine();

        }
    }
}
