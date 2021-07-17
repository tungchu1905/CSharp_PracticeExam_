using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User u = new User();
            Console.WriteLine("User's Infor: ");
            Console.WriteLine(u.ToString());
            Console.WriteLine();

            ArrayList lIstOfUser = new ArrayList();
            lIstOfUser.Add(new User("trungnhhe130147", "trungnhhe130147@fpu", 1));
            lIstOfUser.Add(new User("trungnhhe130148", "trungnhhe130148@fpu", 1));
            lIstOfUser.Add(new User("trungnhhe130149", "trungnhhe130149@fpu", 2));
          

            User u1 = new User("trungnhhe130148", "trungnhhe138148@fpu", 2);
            Console.WriteLine("Index of u1 is ListOfUser: {0}\n", lIstOfUser.IndexOf(u1));
            try
            {
                Object o = new Object();
                Console.WriteLine("Index of o in ListOfUser: ");
                Console.WriteLine(lIstOfUser.IndexOf(o));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
