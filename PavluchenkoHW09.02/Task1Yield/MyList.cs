using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Task1Yield
{
    class MyList<T> : IEnumerable
    {
        T [] arr = null;
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                yield return arr[i];
            }
        }

        public T this[int index]
        {
            get
            {
                return arr[index];
            }
        }

    }
}
