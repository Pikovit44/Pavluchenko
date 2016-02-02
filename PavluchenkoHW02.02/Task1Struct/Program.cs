using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Struct
{
    public struct Notebook
    {
        public string model;
        public string producer;
        public decimal price;

        public Notebook(string model, string producer, decimal price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Model: {0}\nProducer: {1}\nPrice: {2}", model, producer, price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook laptop1 = new Notebook ("Aspire one", "Acer", 300);
            laptop1.ShowInfo();

            Notebook laptop2;
            laptop2.model = "GT 234";
            laptop2.producer = "Lenovo";
            laptop2.price = 320;
            laptop2.ShowInfo();
        }
    }
}
