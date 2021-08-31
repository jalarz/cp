using System;
using System.Collections.Generic;
using System.Text;
using Console_Project.Models;
using Console_Project.Interfaces;



namespace Console_Project.Interfaces
{
    interface IHumanResourcesManager
    {
        Department[] Departments { get; }
        public void AddDepartment(string name, int WorkerLimit, int SalaryLimit);
        public Department[] GetDepartments();
        public void EditDepartment(string OldDepname, string NewDepName);
        public void AddEmployee(string No, string FullName, string Position, int Salary, string Departments);
        public void RemoveEmployee();

        public void EditEmployee();
        public Employee[] ShowEmployees();

    }
}
