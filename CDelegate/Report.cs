using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDelegate
{
    public class Report
    {
        public delegate bool IllegalReport(Employee e);
        public void EmployeeProcess(Employee[] employees , string title , IllegalReport IsIllegal)
        {
            Console.WriteLine(title);
            Console.WriteLine("-------------------------");

            foreach(var e in employees)
            {
                if (IsIllegal(e))
                {
                    Console.WriteLine($"{e.Name} / {e.TotalSalary} / {e.Gender}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
       
}
