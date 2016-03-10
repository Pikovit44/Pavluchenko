using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7MyArrayList
{
    public class MyArrayList
    {
        object[] array;

        public MyArrayList()
        {
            object[] arr = new object[0];
            array = arr;
        }

        int count = 0;
        int capacity = 0;

        public int Capacity
        {
            get { return capacity; }
        }

        public int Count
        {
            get { return count; }
        }

        public void Add<T>(T el)
        {
            count++;

            if (capacity == 0)
                capacity = 2;
            else capacity *= capacity;

            Array.Resize(ref array, capacity);
            
            array[count - 1] = (object)el;
        }

        public object this[int index]
        {
            get { return array[index]; }

        }


    }

}
