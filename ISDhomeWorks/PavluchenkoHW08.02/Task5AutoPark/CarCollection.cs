using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5AutoPark
{

    public class CarCollection<T>
    {

        int count = 0;

        public int Count
        {
            get {return count;}
        }

        List<T> autoPark = null;

        public CarCollection()
            {
            List<T> list = new List<T>();
            autoPark = list;
            }

        public void Add( T car)
        {
            count++;
            autoPark.Add(car);
        }

        public void Del()
        {
            autoPark.Clear();
            count = 0;
        }

        public T this [int index]
        {
            get { return autoPark[index]; }
        }
             

        
    }
}
