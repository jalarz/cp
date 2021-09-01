using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Models
{
    class Department
    {
        
        public string Name;
        private int WorkerLimit;
        private int SalaryLimit;
        public Employee[] Employees;

        public int WorkerLimit1
        { get => WorkerLimit; 
            set
            {
                if (WorkerLimit < 1)
                {
                    Console.WriteLine(" ");
                }
            }
                WorkerLimit = value; }

        public Department(string name, int workerLimit, int salaryLimit)
        {
            Name = name;
            WorkerLimit1 = workerLimit;
            SalaryLimit = salaryLimit;
            Employees = new Employee[0];
        }

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }
        public double CalcSalaryAverage()
        {
            double result = 0;
            foreach (var item in Employees)
            {
                result += item.Salary1;
            }
            return result / Employees.Length;
        }
    }

    }

