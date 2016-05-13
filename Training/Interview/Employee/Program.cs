using Employee.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataXMLFileName = @"..\..\EmployeeContainerXmlData.xml";
            
           // List<BaseEmployee> employees = CreatorEmployees.GetEmployees(6, 5);
            
            EmployeeContainer container = new EmployeeContainer(dataXMLFileName);
            container.SerialazeContainer(dataXMLFileName);
            List<BaseEmployee> emp = container.employees;
            Display.ShowAllEmployees(emp);
            Display.ShowFirstId(emp, 5);
            Display.ShowLastId(emp, 3);
        }
    }
}
