using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePrimeNumbers
{
    public class PrimeGenerator
    {
        ///<summary>
        /// Генерирует массив простых чисел.
        ///</summary>
        ///
        /// <param name=”maxValue”>Верхний порог.</param>
        /// 

        private static int s;
        private static bool[] f;
        private static int[] primes;

        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue < 2)
            {
                return new int[0]; // ставить на первое место?
            }
            else
            {
                InitializeSieve(maxValue);
                Sieve();
                LoadPrimes();
                return primes; 
            }
        }

        private static void LoadPrimes()
        {
            int i;//можно в одну строку?
            int j;

            int count = 0;
            for (i = 0; i < s; i++)
            {
                if (f[i])
                {
                    count++;
                }
            }
            primes = new int[count];
            for (i = 0, j = 0; i < s; i++)
            {
                if (f[i])
                {
                    primes[j++] = i;
                }
            }
        }

        private static void Sieve()
        {
            int i;
            int j;

            for (i = 2; i < Math.Sqrt(s); i++)
            {
                if (f[i])
                {
                    for (j = 2 * i; j < s; j += i)
                    {
                        f[j] = false; // кратное простому - не простое 
                    }
                }
            }
        }
        private static void InitializeSieve(int maxValue)
        {
            s = maxValue + 1;
            f = new bool[s];
            int i; // объявлять i таким образом, а не в циклах?
            for (i = 0; i < s; i++)
            {
                f[i] = true;
            }
            // исключили заведомо не простые числа
            f[0] = f[1] = false;
        }
    }
}
