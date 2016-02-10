using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;


namespace Task1Yield
{
    class EvenList
    {
        
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this ;
        }
            
        public IEnumerable<int> GetEvenClass (int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 0) 
                {
                    yield return arr[i];
                }
            }
        }

       
    }
}

