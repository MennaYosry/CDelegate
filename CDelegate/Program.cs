using System;
namespace CDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[] {
                new Employee { Id = 1, Name = "Menna",TotalSalary=90545,Gender="Female" },
                new Employee { Id = 2, Name = "adel",TotalSalary=30125,Gender="male" },
                new Employee { Id = 3, Name = "soha",TotalSalary=20400,Gender="Female" },
                new Employee { Id = 4, Name = "khaled",TotalSalary=7045,Gender="male" },
                new Employee { Id = 5, Name = "samaa",TotalSalary=100045,Gender="Female" },
                new Employee { Id = 1, Name = "salma",TotalSalary=100045,Gender="Female" },
                new Employee { Id = 2, Name = "shady",TotalSalary=400125,Gender="male" },
                new Employee { Id = 3, Name = "salwa",TotalSalary=800400,Gender="Female" },
                new Employee { Id = 4, Name = "kamal",TotalSalary=29045,Gender="male" },
                new Employee { Id = 5, Name = "samaa",TotalSalary=205045,Gender="Female" }
            };
            Console.ReadKey();
            var report = new Report();
            report.EmployeeProcess(emps, "less than 60,000", lessThansisxtythousands);
        }
        static bool lessThansisxtythousands(Employee e) => e.TotalSalary < 60000;
    }
}