using System;
using Console_Project.Services;
using Console_Project.Interfaces;


namespace Console_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResourcesManager managerService = new HumanResourcesManager();
            do
            {
                Console.WriteLine("1.1 Departameantlerin siyahisini gostermek");
                Console.WriteLine("1.2 Departament yaratmaq ");
                Console.WriteLine("1.3 Departatmentde deyisiklik etmek ");
                Console.WriteLine("2.1 Iscilerin siyahisini gostermek");
                Console.WriteLine("2.2 Departamentdeki iscilerin siyahisini gostermrek ");
                Console.WriteLine("2.3 Isci elave etmek");
                Console.WriteLine("2.4 Isci uzerinde deyisiklik etmek");
                Console.WriteLine("2.5 Departamentden isci silinmesi ");

                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1.1":
                        GetDepartments(ref managerService);
                        break;

                    case "1.2":
                        AddDepartment(ref managerService);
                        break;
                    case "1.3":
                        EditDepartment(ref managerService);
                        break;
                    case "2.1":
                        ShowEmployees(ref managerService);
                        break;
                    case "2.2":
                        ShowDepEmployees(ref managerService);
                        break;
                    case "2.3":
                        AddEmployee(ref managerService);
                        break;
                    case "2.4":
                        EditEmployee(ref managerService);
                        break;
                    case "2.5":
                        RemoveEmployee(ref managerService);
                        break;


                    default:
                        Console.WriteLine("Tekrar secim edin!");
                        break;
                }

            } while (true);
        }
        static void AddDepartment(ref HumanResourcesManager managerService)
        {
            Console.WriteLine("Department adini daxil edin");
            string Name = Console.ReadLine();
            Console.WriteLine("Worker Limit daxil edin:");
            try
            {
                int WorkerLimit = Convert.ToInt32(Console.ReadLine());
                if (WorkerLimit < 1)
                {
                    Console.WriteLine("Limit 1-den boyuk olmalidir");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Zehmet olmasa reqem daxil edin!");
            }
            Console.WriteLine("Salary Limit daxil edin:");
            try
            {
                int SalaryLimit = Convert.ToInt32(Console.ReadLine());
                if (SalaryLimit < 250)
                {
                    Console.WriteLine("Limit 250-den boyuk olmalidir");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Zehmet olmasa reqem daxil edin!");
            }
            managerService.AddDepartment(Name, WorkerLimit, SalaryLimit);



        }
        static void EditDepartment(ref HumanResourcesManager managerService)
        {
            Console.WriteLine("Deyismek istediyiniz departamentin adini daxil edin:");
            string OldDepName = Console.ReadLine();

            if (managerService.FindDepartment(OldDepName) == null)
            {
                Console.WriteLine($"{OldDepName} adli departament movcud deyil!");
                return;
            }

            Console.WriteLine("Qrupun yeni nomresini daxil edin:");
            string NewDepName = Console.ReadLine();

            if (managerService.FindDepartment(NewDepName) != null)
            {
                Console.WriteLine($"{NewDepName} adli departament movcuddur!");
                return;
            }

            managerService.EditDepartment(OldDepName, NewDepName);
        }
        static void GetDepartments(ref HumanResourcesManager managerService)
        {
            if (managerService.Departments.Length>0)
            {
                Console.WriteLine("Departamentler:");
                foreach (var item in managerService.Departments)
                {
                    Console.WriteLine($"Name: {item.Name} - Worker Limit: {item.WorkerLimit} - Salary Limit: {item.SalaryLimit} - Employees: {item.Employees} - Average Salary: {item.AvSalary}");
                }
            }
            else
            {
                Console.WriteLine("Sistemde hec bir departament yoxdur");
            }
        }

    } }

