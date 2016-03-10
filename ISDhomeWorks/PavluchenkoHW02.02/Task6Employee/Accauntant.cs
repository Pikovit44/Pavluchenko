using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6Employee
{
    public class Accauntant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            if ( (int)worker <= hours)
            {
                return true;
            }
            else
            {
                return false;
            }
             
        }
    }
}
