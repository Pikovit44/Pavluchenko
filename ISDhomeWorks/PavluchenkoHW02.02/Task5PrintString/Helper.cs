using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5PrintString
{
   public static class Helper
    {

        public static byte EnterMenu(string name)
        {
            bool correct = true;
            byte side = 0;

            do
            {
                correct = true;
                Console.WriteLine("Enter {0}:", name);
                try
                {
                    side = byte.Parse(Console.ReadLine());
                    if (side < 1 || side > 3)
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

        public static int EnterYear(string name)
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
                    if (side <= 0 || side > 2016)
                    {
                        throw new System.ArgumentException("incorrect value, try again (you must enter value from 0 to 2016)");
                    }
                }
                catch
                {
                    Console.WriteLine("incorrect value, try again (you must enter value from 0 to 2016)");
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

        public static int EnterMonth(string name)
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
                    if (side < 0 || side > 12)
                    {
                        throw new System.ArgumentException("incorrect value, try again (you must enter value from 1 to 12)");
                    }
                }
                catch
                {
                    Console.WriteLine("incorrect value, try again (you must enter value from 1 to 12)");
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

        public static int EnterDay(string name)
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
                    if (side <= 0 || side > 2016)
                    {
                        throw new System.ArgumentException("incorrect value, try again (you must enter value from 1 to 31)");
                    }
                }
                catch
                {
                    Console.WriteLine("incorrect value, try again (you must enter value from 1 to 31)");
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
    }
}

