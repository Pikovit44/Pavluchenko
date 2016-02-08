using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Dictionary
{
    class MyDictionary <TKey, TValue>
    {
        //public struct KeyValue
        //{
        //    public TKey Key;
        //    public TValue Value;
        //}


        int count = 0;
        List<TKey> KeysList = null;
        List<TValue> ValueList = null;

        public int Count
        {
            get { return count; }
        }

        public TValue this [TKey key]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < KeysList.Count; i++)
                {
                    if (key.Equals(KeysList[i]))
                    {
                        index = i;
                    }
                }
                return ValueList[index];
              
            }
        }   
 
        public void Add (TKey key, TValue value)
        {
            count++;
            KeysList.Add(key);
            ValueList.Add(value);
        }
         

    }
}
