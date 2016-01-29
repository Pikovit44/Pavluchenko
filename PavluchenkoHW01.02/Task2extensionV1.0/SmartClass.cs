using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2extensionV1._0
{
    public static class SmartClass
    {
        public static void Sort ( int [] arr, bool flag )
        {
            int tmp;
            if (flag == true)
                MyClass.MethodSort(arr);
            else
                
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }
    }
}
