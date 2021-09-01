using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Models
{
    class Department
    {
        
        public string Name;
        public int WorkerLimit;
        public int SalaryLimit;
        public Employee[] Employees;
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }
        static double CalcSalaryAverage(int[] Salary)
        {
            double result = 0;
            foreach (var item in Salary)
            {
                result += item;
            }
            return result / Salary.Length;
        }
    }

    }

