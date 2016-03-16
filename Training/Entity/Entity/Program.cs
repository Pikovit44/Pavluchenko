using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            Database1Entities contest = new Database1Entities();
            List<Table> list =  contest.Tables.ToList();
            foreach (Table item in list)
            {
                Console.WriteLine("{0}.{1} - {2} {3}",item.Id, item.first_name, item.last_name, item.age);
            }
        }
    }
}
