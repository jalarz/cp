using System;
using Console_Project.Services;


namespace Console_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResourcesManager managerSevice = new HumanResourcesManager();
            do
            {
                Console.WriteLine("1.1 Departameantlerin siyahisini gostermek");
                Console.WriteLine("1.2 Departamenet yaratmaq ");
                Console.WriteLine("1.3 Departmanetde deyisiklik etmek ");
                Console.WriteLine("2.1 Iscilerin siyahisini gostermek");
                Console.WriteLine("2.2 Departamentdeki iscilerin siyahisini gostermrek ");
                Console.WriteLine("2.3 Isci elave etmek");
                Console.WriteLine("2.4 Isci uzerinde deyisiklik etmek");
                Console.WriteLine("2.5 Departamentden isci silinmesi ");

                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1.1":
                        GetDepartments(ref managerSevice);

                    case "1.2":
                        AddDepartment(ref managerSevice);

                    case "1.3":
                        EditDepartment(ref managerSevice);

                    case "2.1":
                        ShowEmployees(ref managerSevice);

                    case "2.2":
                        ShowDepEmployees(ref managerSevice);

                    case "2.3":
                        AddEmployee(ref managerSevice);

                    case "2.4":
                        EditEmployee(ref managerSevice);

                    case "2.5":
                        RemoveEmployee(ref managerSevice);

                

                    default:
                        Console.WriteLine("Tekrar secim edin!");
                        break;
                }

            } while (true);
            static void AddDepartment(ref HumanResourcesManager managerService);
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

                managerSevice.AddDepartment(Name, WorkerLimit, SalaryLimit);


            }
        }
        
    }
}
