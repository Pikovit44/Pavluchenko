using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePrimeNumbers
{
    public class GeneratePrimers
    {
        ///<summary>
        /// Генерирует массив простых чисел.
        ///</summary>
        ///
        /// <param name=”maxValue”>Верхний порог.</param>
        /// 

        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue >= 2)//единственный допустимый случай
            {
                int s = maxValue + 1;
                bool[] f = new bool[s];
                int i;

                // инициализировать элементы массива значением true.
                for (i = 0; i < s; i++)
                {
                    f[i] = true;
                }

                // исключить заведомо не простые числа
                f[0] = f[1] = false;

                //решето
                int j;
                for (i = 2; i < Math.Sqrt(s); i++)
                {
                    if (f[i])
                    {
                        for (j = 2 * i; j < s; j += i)
                        {
                            f[j] = false;
                        }
                    }
                }

                //колличество простых чисел
                int count = 0;
                for (i = 0; i < s; i++)
                {
                    if (f[i])
                    {
                        count++;
                    }
                }

                int[] primes = new int[count];

                //записать простые числа в результирующий массив
                for (i = 0, j = 0; i < s; i++)
                {
                    if (f[i]) // если простое
                    {
                        primes[j++] = i;
                    }
                }
                return primes; 
            }
            else
            {
                return new int[0];
            }
        }
    }
}
