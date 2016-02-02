using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Train
{
   public static class Helper
    {

        public static int EnterMenu(string name)
        {
            bool correct = true;
            int side = 0;

            do
            {
                correct = true;
                Console.WriteLine("Enter {0}:", name);
                try
                {
                    side = int.Parse(Console.ReadLine());
                    if (side <= 0 || side > 4)
                    {
                        throw new System.ArgumentException("incorrect value, try again");
                    }
                }
                catch
                {
                   
                    Console.WriteLine("incorrect value, try again");
                    correct = false;
                }

                finally
                {
                    if (side == 0)
                    {
                        side = 1;
                    }

                }

            } while (!correct);

            return side;
        }

        public static double EnterDouble (string name)
        {
            bool correct = true;
            double side = 0;

            do
            {
                correct = true;
                Console.WriteLine("Enter {0}:", name);
                try
                {
                    side = Double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("incorrect value, try again");
                    correct = false;
                }

                finally
                {
                    if (side == 0)
                    {
                        side = 1;
                    }

                }

            } while (!correct);

            return side;
        }

        public static int EnterInt(string name)
        {
            bool correct = true;
            int side = 0;

            do
            {
                correct = true;
                Console.WriteLine("Enter {0}:", name);
                try
                {
                    side = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("incorrect value, try again");
                    correct = false;
                }

                finally
                {
                    if (side == 0)
                    {
                        side = 1;
                    }

                }

            } while (!correct);

            return side;
        }

        public static string EnterStr(string name)
        {
            bool correct = true;
            string side = null;

            do
            {
                correct = true;
                Console.WriteLine("Enter {0}:", name);
                try
                {
                    side = (Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("incorrect value, try again");
                    correct = false;
                }

                finally
                {
                    if (side == null)
                    {
                        side = " ";
                    }

                }

            } while (!correct);

            return side;
        }

    }
}

