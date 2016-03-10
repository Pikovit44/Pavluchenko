using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Train
{
    class Program
    {
        public struct Train: IComparable
        {
            public string destination;
            public int numberOfTrain;
            public DateTime timeOfDeparture;
             
            public void ShowInfo ()
            {
                Console.WriteLine("{0}, {1}, {2}", numberOfTrain, destination, timeOfDeparture);
            }

            int IComparable.CompareTo(object input)
            {
                Train tmp = (Train)input;

                if (this.numberOfTrain > tmp.numberOfTrain)
                    return 1;

                else if (this.numberOfTrain < tmp.numberOfTrain)
                    return -1;
                else
                return 0;
            }


        }

        static void Main(string[] args)
        {   
            
            Train[] tablo = { new Train(), new Train(), new Train(), new Train(), new Train(), new Train(), new Train(), new Train() };
            for (int i = 0; i < tablo.Length; i++)
            {
                int hour = 0 ,  minute = 0;
                Console.WriteLine("Enter information about {0} train", i+1);
                tablo[i].numberOfTrain = Helper.EnterInt("number of train");
                tablo[i].destination = Helper.EnterStr("destination");
                Console.WriteLine("Enter time of depaкture." );
                hour = Helper.EnterInt("Enter hours");
                minute = Helper.EnterInt("Enter minutes");
                tablo[i].timeOfDeparture = new DateTime(2016, 2, 2, hour, minute, 0);
            }
            Array.Sort(tablo);

            for (int i = 0; i < tablo.Length; i++)
            {
                tablo[i].ShowInfo();
                Console.WriteLine();
            }


            int numbForInfo = Helper.EnterInt("number of train for getting information");
            for (int i = 0; i < tablo.Length; i++)
            {
                if (tablo[i].numberOfTrain == numbForInfo)
                {
                    tablo[i].ShowInfo();
                    break;
                }
            }



        }
    }
}
