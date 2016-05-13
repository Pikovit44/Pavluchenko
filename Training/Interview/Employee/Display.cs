using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public static class Display
    {
        public static void ShowAllEmployees(List<BaseEmployee> employees)
        {
            List<BaseEmployee> em = SortEmployees(employees);
            ShowAll(em);
        }

        public static void ShowFirstId(List<BaseEmployee> employees, int count)
        {
            List<BaseEmployee> em = SortEmployees(employees);
            List<BaseEmployee> countEmpl = em.Take(count).ToList();
            ShowId(countEmpl);
            
        }

        public static void ShowLastId(List<BaseEmployee> employees, int count)
        {
            List<BaseEmployee> em = SortEmployees(employees);
            em = em.Distinct().Take(count).ToList();
            ShowId(em);
        }

        static List<BaseEmployee> SortEmployees(List<BaseEmployee> employees)
        {
            List<BaseEmployee> sortEmployees = employees.OrderBy(a => a.AverageMonthlySalary).
                        ThenBy(n => n.LastName).
                        ToList();
            return sortEmployees;
        }

        static void ShowId(List<BaseEmployee> countEmpl)
        {
            foreach (var id in countEmpl)
            {
                Console.WriteLine("Id: {0}", id.Id);
            }
            Console.WriteLine();
        }

        static void ShowAll(List<BaseEmployee> em)
        {
            foreach (var e in em)
            {
                Console.WriteLine("Id: {0}, Average salary: {1}, Last name {2}", e.Id, e.AverageMonthlySalary, e.LastName);
            }
            Console.WriteLine();
        }
    }
}
