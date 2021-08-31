﻿using System;
using System.Collections.Generic;
using System.Text;
using Console_Project.Interfaces;
using Console_Project.Models;
    

namespace Console_Project.Services
{
    class HumanResourcesManager : IHumanResourcesManager
    {
        private Department[] _departments;
        public HumanResourcesManager()
        {
            _departments = new Department[0];
            
        }
        public Department[] Departments => _departments;

        public void AddDepartment(string name, int WorkerLimit, int SalaryLimit )
        {
            Department departments = new Department();
            foreach (Department department in _departments)
            {
                if (department.Name.ToLower() == name.ToLower())
                {
                    Console.WriteLine($"{department.Name.ToLower()} adli departament movcuddur");
                    return;
                }
               
            }
            
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = departments;
        }
        
        public Department [] GetDepartments()
        {
            //Department[] departments = new Department[0];

            //foreach (var department in _departments)
            //{
            //    foreach (var dep in _departments)
            //    {
            //        Array.Resize(ref departments, departments.Length + 1);
            //        departments[departments.Length - 1] = dep;
            //    }
            //}

            return Departments;
        }
        public void AddEmployee(string No, string FullName, string Position, int Salary, string Departments)
        {
            Department department = FindDepartment(Departments);
            if(department == null)
            {
                Console.WriteLine($"{Departments} adli departament movcud deyil!");
                return;
            }
            if (department.Employees.Length >= department.WorkerLimit)
            {
                Console.WriteLine($"{Departments} adli departamentde yer yoxdur!");
                return;
            }

            Employee employee = new Employee(No, FullName,Position, Salary, Departments);
            department.AddEmployee(employee);
        }
        public Department FindDepartment(string name)
        {
            foreach (var item in _departments)
            {
                if (item.Name == name)
                {
                    return item;

                }
                
            }
            return null;
        }
        public void EditDepartment(string OldDepName, string DepNewName)
        {
            Department department = FindDepartment(DepNewName);
            if (department == null)
            {
                Console.WriteLine($"{department.Name} nomreli qrup movcud deyil!");
                return;
            }
            else
            {
                if (FindDepartment(DepNewName) != null)
                {
                    Console.WriteLine($"{DepNewName} nomreli qrup movcuddur!");
                    return;
                }

                department.Name = DepNewName;
            }
        }
        public Employee[] ShowEmployees()
        {
            Employee[] employees = new Employee[0];
            foreach (var department in _departments)
            {
                foreach (var eml in department.Employees)
                {
                    Array.Resize(ref employees, employees.Length + 1);
                    employees[employees.Length - 1] = eml;
                }
            }

            return employees;
        }
        public void RemoveEmployee()
        {

        }
        public void EditEmployee()
        {

        }
    }
    }

