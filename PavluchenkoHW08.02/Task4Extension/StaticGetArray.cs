using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Extension
{

    public class MyList<T>
    {

        T[] arr = null;
        public MyList()
        {
            T[] newArr = new T[0];
            arr = newArr;
        }

        public int Count
        {
            get { return arr.Length; }
        }

        public void Add(T el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = el;
        }

        public T this[int index]
        {
            get
            {
                return arr[index];
            }
        }

    }
    static class StaticGetArray
    {

        public static void  GetArray<T>(this MyList<T> list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0} element: {1}" , i+1, list[i]);
            }
            
        }
    }
}
