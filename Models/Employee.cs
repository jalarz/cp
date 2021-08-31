using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Models
{
    class Employee
    {
        public static int Counter = 1000;
        public Employee(string str, string Fullname, string Position, int Salary, string Departments)
        {
            Counter++;
            No = str;
            str.Substring(0, 2);

            
        }
        public string No;
        public string Fullname;
        public string Position;
        public int Salary;
        public string Departments;
        
        }

    }

