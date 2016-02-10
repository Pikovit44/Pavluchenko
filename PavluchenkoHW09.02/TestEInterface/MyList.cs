using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEInterface
{
    class MyList 
    {
        int[] array = null;
        int position = -1;
        

        public MyList()
        {
            int[] arr = new int[0];
            array = arr;
        }

        public int Count
        {
            get { return array.Length; }
        } 
           
        public void Add( int el )
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = el;
        }

        public int this [int index]
        {
            get { return array[index]; }
        }

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator(); 
        }


            
    }
}
