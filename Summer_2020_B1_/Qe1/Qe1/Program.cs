using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s.ToString());
            while (true)
            {
                Console.WriteLine("\nInput information of Student");
                try
                {
                    Console.WriteLine("New Code: ");
                    s.Code = Console.ReadLine();
                    Console.WriteLine("New Name: ");
                    s.Name = Console.ReadLine();
                    Console.WriteLine("New DOB: ");
                    s.Dob =Convert.ToDateTime( Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Input again, pls");
                }
            }
            Console.WriteLine(s.ToString());
            Console.ReadLine();
        }
    }
}
