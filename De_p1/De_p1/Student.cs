using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace De_p1
{
    class Student
    {
       public int id;
        public string name;
        public DateTime dob;

        public Student(int id, string name, DateTime dob)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
        }

        public Student()
        {
        }
        public int GetAge()
        {
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age = age - 1;
            return age;
        }
        public string ToString()
        {
            return "Student's Information: ID: " + id + " Name: " + name + " Age: " + GetAge();
        }
    }
}
