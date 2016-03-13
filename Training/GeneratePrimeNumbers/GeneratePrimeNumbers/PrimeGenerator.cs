﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePrimeNumbers
{
    public class PrimeGenerator
    {
        private static bool[] crossedOut;
        private static int[] result;

        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue < 2)
            {
                return new int[0]; // ставить на первое место?
            }
            else
            {
                UncrossIntegersUpTo(maxValue);
                CrossOutMultiples();
                PutUncrossedIntegersIntoResult();
                return result; 
            }
        }

        private static void UncrossIntegersUpTo(int maxValue)
        {
            crossedOut = new bool[maxValue + 1];
            for (int i = 2; i < crossedOut.Length; i++)
            {
                crossedOut[i] = false;
            }
        }

        private static void PutUncrossedIntegersIntoResult()
        {
            result = new int[NumberOfUncrossedIntegers()];
            for (int i = 2, j = 0; i < crossedOut.Length; i++)
            {
                if (NotCrossed(i))
                {
                    result[j++] = i;
                }
            }
        }

        private static int NumberOfUncrossedIntegers()
        {
            int count = 0;
            for (int i = 2; i < crossedOut.Length; i++)
            {
                if (NotCrossed(i))
                {
                   count++;
                }
            }
            return count;
        }

        private static void CrossOutMultiples()
        {
            int limit = DetermineInterationLimit();
            for (int i = 2; i <= limit; i++)
            {
                if (NotCrossed(i))
                {
                    CrossOutputMultiplesOf(i);
                }
            }
        }

        private static int DetermineInterationLimit()
        {
            double interationLimit = Math.Sqrt(crossedOut.Length);
            return (int)interationLimit;
        }

        private static void CrossOutputMultiplesOf(int i)
        {
            for (int multiple = 2 * i; multiple < crossedOut.Length;  multiple += i)
            {
                crossedOut[multiple] = true;
            }
        }
        

        private static bool NotCrossed(int i)
        {
            return crossedOut[i] == false;
        }


        


    }
}
