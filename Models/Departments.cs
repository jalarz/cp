using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Models
{
    public class Department
    {
        public string Name;
        public int WorkerLimit;
        public int SalaryLimit;
        public Employee[] Employees;
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees,Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }



    }
}
