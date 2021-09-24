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

           

            if (Name.Length < 2)
            {
                Console.WriteLine("Daxil etdiyinz ad 2 herfden chox olmalidir");
                return;
            }
        tryagain1:
            Console.WriteLine("Worker Limit daxil edin:");
            int WorkerLimit = 0;
            try
            {
                WorkerLimit = Convert.ToInt32(Console.ReadLine());
                if (WorkerLimit < 1)
                {
                    Console.WriteLine("Limit 1-den boyuk olmalidir");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Zehmet olmasa reqem daxil edin!");
                
                goto tryagain1;
                throw;
            }
        tryagain2:
            Console.WriteLine("Salary Limit daxil edin:");
            int SalaryLimit = 0;
            try
            {
                SalaryLimit = Convert.ToInt32(Console.ReadLine());
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Zehmet olmasa reqem daxil edin!");
                
                goto tryagain2;
                throw;
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

            Console.WriteLine("Departamentin yeni adini daxil edin:");
            string NewDepName = Console.ReadLine();

            if (managerService.FindDepartment(NewDepName) != null)
            {
                Console.WriteLine($"{NewDepName} adli departament movcuddur!");
                return;
            }

            managerService.EditDepartment(OldDepName, NewDepName);
        }
        static void ShowEmployees(ref HumanResourcesManager managerService)
        {
            foreach (var item in managerService.GetAllEmployees())
            {
                Console.WriteLine($"No: {item.No} - Ad Soyad: - {item.Fullname} - Position: {item.Position} - Salary: {item.Salary} - Department: {item.Departments}");
            }
        }
        static void GetDepartments(ref HumanResourcesManager managerService)
        {
            if (managerService.Departments.Length>0)
            {
                Console.WriteLine("Departamentler:");
                foreach (var item in managerService.Departments)
                {
                    Console.WriteLine($"Name: {item.Name} - Worker Limit: {item.WorkerLimit} - Salary Limit: {item.SalaryLimit} - Employees: {item.Employees} - Average Salary: {item.CalcSalaryAverage()}");
                }
            }
            else
            {
                Console.WriteLine("Sistemde hec bir departament yoxdur");
            }
        }
       
        static void RemoveEmployee(ref HumanResourcesManager managerService)
        {
            Console.WriteLine("Iscini nomresini daxil edin:");
            string No = Console.ReadLine();
            Console.WriteLine("Iscinin adini daxil edin");
            string FullName = Console.ReadLine();
        }
        static void EditEmployee(ref HumanResourcesManager managerService)
        {
            Console.WriteLine("Deyismek istediyiniz iscinin nomresini daxil edin");
            string No = Console.ReadLine();
            if (managerService.SearchEmployee(No) == null)
            {
                Console.WriteLine($"{No} adli departament movcud deyil!");
                return;
            }

            Console.WriteLine("Ischinin yeni position daxil edin:");
            string NewPosition = Console.ReadLine();

            Console.WriteLine("Iscinin yeni salary daxil edin:");
            string typeNewSalary = Console.ReadLine();
            int NewSalary;
            while (!int.TryParse(typeNewSalary, out NewSalary))
            {
                Console.WriteLine("Yeniden daxil edin");
                typeNewSalary = Console.ReadLine();
            }
            managerService.EditEmployee(No, NewPosition, NewSalary);
        }
        static void ShowDepEmployees(ref HumanResourcesManager managerService)
        {
            Console.WriteLine("Departament adini daxil edin");
            string department = Console.ReadLine();
            if (managerService.FindDepartment(department) == null)
            {
                Console.WriteLine($"{department} adli departament movcud deyil");
                return;
            }
            foreach (var item in managerService.GetEmployeebyDepartment(department))
            {
                Console.WriteLine($"No: {item.No} - Ad Soyad: - {item.Fullname} - Position: {item.Position} - Salary: {item.Salary} - Department: {item.Departments}");
           
            }
        }
        static void AddEmployee(ref HumanResourcesManager managerService)
        {
            Console.Write("Iscinin adi:");
            string Fullname = Console.ReadLine();
            Console.Write("Position daxil edin:");
            string Position = Console.ReadLine();
            Console.Write("Salary daxil edin:");
            int Salary = 0;
            tryagain1:
            try
            {
                Salary = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Zehmet olmasa duzgun format daxil edin");
               
                goto tryagain1;
                throw;
            }
            Console.Write("Departament adini daxil edin:");
            string Departments = Console.ReadLine();
            managerService.AddEmployee(Fullname, Position, Salary, Departments);
        }
    } }

