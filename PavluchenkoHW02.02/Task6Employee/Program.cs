using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6Employee
{
    public enum Post
    {
        junior = 160,
        middle = 130,
        senior = 100
    }
    class Program
    {
        static void Main(string[] args)
        {
            if (Accauntant.AskForBonus(Post.junior, 120))
                Console.WriteLine("Award");
            else
                Console.WriteLine("No award");

        }
    }
}
