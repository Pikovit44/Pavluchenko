using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Facroty
{
    class MyClass<T> where T: new ()
    {
        public  T FacrotyMethod()
        {
            return new T();
        }
    }


    
}
