using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Models
{
    class Employee
    {
        public static int Counter = 1000;
        public Employee(string str, string fullname, string position, int salary, string departments)
        {
            Counter++;
            No = Departments.Substring(0, 2).ToUpper() + Counter;
            
                Fullname = fullname;
                Position = position;
                Salary = salary;
                Departments = departments;
            
        }

        public Employee(string fullName, string position, int salary, string departments)
        {
            Fullname = fullName;
            Position = position;
            Salary = salary;
            Departments = departments;
        }

        public string No;
        public string Fullname;
        private string _Position;
        private int _Salary;
        public string Departments;

        public string Position
        {
            get => _Position;
            set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("Position adi 2 herfden boyuk olmalidir");
                    return;
                }
                _Position = value;
            }
        }
        public int Salary
        {
            get => _Salary;
            set
            {
                if (value < 250)
                {
                    Console.WriteLine("Salary deyeri 250den yuksek olmalidir");
                    return;
                }
                _Salary = value;
            }




        }
    }
}


