using Employee.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public static class Handler
    {
        static int Id = 0;

        public static int GetId()
        {
            return Id++;
        }
    }
}
