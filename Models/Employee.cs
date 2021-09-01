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
            No = Departments.Substring(0, 2).ToUpper() + Counter;
        }


        public string No;
        public string Fullname;
        private string Position;
        private int Salary;
        public string Departments;

        public string Position1
        {
            get => Position;
            set
            {
                if (Position.Length < 2)
                {
                    Console.WriteLine("Position adi 2 herfden boyuk olmalidir");
                    return;
                }
                Position = value;
            }
        }
        public int Salary1
        {
            get => Salary;
            set
            {
                if (Salary < 250)
                {
                    Console.WriteLine("Salary deyeri 250den yuksek olmalidir");
                }
                Salary = value;
            }




        }
    }
}


