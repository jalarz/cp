using System;
using System.Collections.Generic;
using System.Text;
using Console_Project.Interfaces;
using Console_Project.Models;
    

namespace Console_Project.Services
{
    class HumanResourcesManager : IHumanResourcesManager
    {
        private Departments[] _departments;
        public Departments()
        {
            _departments = new Departments[0];
            
        }
        public Departments[] Departments => _departments;

        public void AddDepartment(string name)
        {
            foreach (Departments department in _departments)
            {
                if (department.Name.ToLower() == name.ToLower())
                {
                    Console.WriteLine();
                    return;
                }
               
            }
            Departments departments = new Departments(Name);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = departments;
        }
        
        public Departments [] GetDepartments()
        {
            Departments[] departments = new Departments[0];

            foreach (var departments in _departments)
            {
                foreach (var dep in departments.AllDepartments)
                {
                    Array.Resize(ref departments, departments.Length + 1);
                    departments[departments.Length - 1] = dep;
                }
            }

            return departments;
        }
    }
}
