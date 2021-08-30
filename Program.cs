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
                {case "1.1";
                        GetDepartments(ref managerSevice); 
                    default:
                        break;
                }

            } while (true);
            static void AddDepartment(ref HumanResourcesManager managerService);
            {
                Console.WriteLine("Department adini daxil edin");
            }
        }
        
    }
}
