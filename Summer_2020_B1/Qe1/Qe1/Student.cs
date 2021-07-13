using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Qe1
{
    class Student
    {
        string code;
        string name;
        DateTime dob;

        public Student()
        {
        }

        public Student(string code, string name, DateTime dob)
        {
            this.code = code;
            this.name = name;
            this.dob = dob;
        }

        public string Code
        {
            get { return code; }

            set
            {
                if (checkCode(code))
                {
                    code = value;
                }
                //else code = null;
                // @"^(HE|SE)\d{6}$  
               
            }

        }
        public string Name { get => name; set => name = value; }
        public DateTime Dob { get => dob; set => dob = value; }

        public bool checkCode(string code)
        {
            string patten = @"^[a - zA - Z\s]{2}\d{6}$";
            Regex regex = new Regex(patten);
            
                code = Console.ReadLine();
                if (!regex.IsMatch(code))
                {
                //Console.WriteLine("roll is not right format");
                return false;
                }
                else
                {
                    return true;
                }
            
        }

        public string ToString()
        {
            return "Student's Infor: \n" + "Code: " + code + ", Name: " + name + ", Dob: " + dob;
        }

    }
}
