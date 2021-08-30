using System;
using System.Collections.Generic;
using System.Text;
using Console_Project.Models;
using Console_Project.Interfaces;



namespace Console_Project.Interfaces
{
    interface IHumanResourcesManager
    {
        Departments[] Departments { get; }
        public void AddDepartment();
        public void GetDepartment();
        public void EditDepartment();
        public void AddEmployee();
        public void RemoveEmployee();

        public void EditEmployee();

    }
}
