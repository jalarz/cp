using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Models
{
    class Employee
    {
        public Employee(string no, string fullname, string position, int salary, string departmentname)
        {
            EmployeeNo =  no,
            FullName = fullname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentname
        }

    }
}
