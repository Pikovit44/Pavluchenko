using Employee.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public static class CreatorEmployees
    {
        static Random r = new Random();

        static string[] lastNames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis" ,"Miller",
                "Wilson", "Moore", "Taylor" ,"Anderson", "Thomas", "Jackson" ,"White" ,"Harris" ,"MartinThompson" ,
                "Wood" ,"Lewis" ,"Scott" ,"Cooper" };

        static List<BaseEmployee> employees;

        public static List<BaseEmployee> GetEmployees(int fEmployee, int hEmployee)
        {
            employees = new List<BaseEmployee>(fEmployee + hEmployee);
            CreateFemployees(fEmployee);
            CreateHemployees(hEmployee);
            return employees;
        }

        static void CreateFemployees(int count)
        {
            FixedPaymentEmployee fEmployee;
            for (int i = 0; i < count; i++)
            {
                fEmployee = new FixedPaymentEmployee(GetLastName(), GetFsalary());
                employees.Add(fEmployee);
            }
        }

        static void CreateHemployees(int count)
        {
            HourlyPaymentEmployee hEmployee;
            for (int i = 0; i < count; i++)
            {
                hEmployee = new HourlyPaymentEmployee(GetLastName(), GetHsalary());
                employees.Add(hEmployee);
            }
        }

        static string GetLastName()
        {
            return lastNames[r.Next(0, 20)];
        }

        static decimal GetFsalary()
        {
            return r.Next(3, 20) * 100;
        }

        static decimal GetHsalary()
        {
            return r.Next(2, 8) ;
        }
    }
}
