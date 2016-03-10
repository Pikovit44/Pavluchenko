using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3ClassAndStruct
{
    public struct MyStruct
    {
        public string change;
        public static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass firstClass = new MyClass();
            MyStruct firstStruct;

            firstClass.change = "не изменено";
            firstStruct.change = "не изменено";

            MyStruct.StructTaker(firstStruct);
            MyClass.ClassTaker(firstClass);

            Console.WriteLine("Class's field: {0}", firstClass.change);
            Console.WriteLine("Struct's field: {0}", firstStruct.change);

        }
    }
}
