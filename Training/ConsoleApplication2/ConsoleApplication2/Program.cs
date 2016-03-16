using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyModel context = new MyModel();
            

            context.PersonalInfos.Add(new PersonalInfo { FirstName = "Bob", LastName = "Parker", Age = 22 });
            var list = context.PersonalInfos.ToList();

            foreach (var item in list)
            {
                Console.WriteLine("{0}, {1}", item.Id, item.LastName);
            }
            context.SaveChanges();
        }
    }
}
