using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3ClassAndStruct
{
    public class MyClass
    {
        public string change;
        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
    }
}
