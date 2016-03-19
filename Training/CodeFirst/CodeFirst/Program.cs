using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var cntx = new SchoolContext())
            {
                Student stud = new Student { StudentName = "New Student" };

                cntx.Students.Add(stud);
                cntx.SaveChanges();
            }
        }
    }
}
