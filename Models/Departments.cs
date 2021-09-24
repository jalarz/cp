using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Models
{
    class Department
    {
        
        public string Name;
        private int _WorkerLimit;
        private int _SalaryLimit;
        public Employee[] Employees;

        public int WorkerLimit
        { get => _WorkerLimit; 
            set
            {
               
                _WorkerLimit = value;
            }
        }
        public int SalaryLimit
        {
            get => _SalaryLimit;
            set
            {
                
               
                _SalaryLimit = value;
            }
        }

        public Department(string name, int workerLimit, int salaryLimit)
        {
            Name = name;
            WorkerLimit = workerLimit;
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
                result += item.Salary;
            }
            return result / Employees.Length;
        }
    }

    }

