using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3DelArray
{
    public delegate int RandDel();
    public delegate float AverageDel(RandDel [] arr);



    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            RandDel Del1 = delegate { return r.Next(0,100);};
            RandDel Del2 = delegate { return r.Next(0, 100); };
            RandDel Del3 = delegate { return r.Next(0, 100); };

            RandDel[] delArr = { Del1, Del2, Del3 };

            AverageDel delRresult = arr => 
            {
                float res = 0; 
                for (int i = 0; i < arr.Length; i++)
                {
                    res += arr[i]();
                }
                return res/3;
            };

            Console.WriteLine(delRresult(delArr));

        }
    }
}
