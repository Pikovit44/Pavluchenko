using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;


namespace Task1Yield
{
    class EvenList: IEnumerable
    {
        int[] numbers;
        public EvenList()
        {
            int [] newArr = new int[0];
            numbers = newArr;

        }
           
        public MyList<int> GetEvenList(int[] arr)
        {
            numbers = arr;
            MyList<int> evenNumb = new MyList<int>();
            foreach (int item in numbers)
            {
                evenNumb.Add(item);
            }
            return evenNumb;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    yield return numbers[i];
                }
                
            }
        }
    }
}
