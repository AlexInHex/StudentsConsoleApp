using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp
{
    class Student
    {
        public string name;
        public string secondName;
        public string gender;
        public int age;

        public Student(string n, string secondN, string g, int a)
        {
            name = n;
            secondName = secondN;
            gender = g;
            age = a;


        }
    }
}
