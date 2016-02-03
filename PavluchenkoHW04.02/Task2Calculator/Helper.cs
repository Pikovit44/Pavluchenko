using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Calculator
{
   public static class Helper
    {

        public static int GetMenu(string [] items)
        {
            bool correct = true;
            int result = 0;

            do
            {
                correct = true;
                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine("{0}.{1}", i+1, items[i]);
                }
                Console.WriteLine("Enter item of menu");
                try
                {
                    result = int.Parse(Console.ReadLine());
                    if (result < 1 || result > items.Length + 1)
                    {
                        Console.WriteLine("Incorrect value, try again");
                        correct = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect value, try again");
                    correct = false;
                }

                finally
                {
                    if (result == 0)
                    {
                        result = 1;
                    }

                }

            } while (!correct);

            return result;
        }

        public static double GetDouble (string name)
        {
            bool correct = true;
            double result = 0;

            do
            {
                correct = true;
                Console.WriteLine("Enter {0}:", name);
                try
                {
                    result = Double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("incorrect value, try again");
                    correct = false;
                }

                finally
                {
                    if (result == 0)
                    {
                        result = 1;
                    }

                }

            } while (!correct);

            return result;
        }

        public static int GetInt(string name, int min, int max)
        {
            bool correct = true;
            int result = 0;

            do
            {
                correct = true;
                Console.WriteLine("Enter {0}:", name);
                try
                {
                    result = int.Parse(Console.ReadLine());
                    if (result < min || result > max)
                    {
                        Console.WriteLine("incorrect value, try again");
                        correct = false;
                    }
                        
                }
                catch
                {
                    Console.WriteLine("incorrect value, try again");
                    correct = false;
                }

                finally
                {
                    if (result == 0)
                    {
                        result = 1;
                    }

                }

            } while (!correct);

            return result;
        }

        

    }
}

