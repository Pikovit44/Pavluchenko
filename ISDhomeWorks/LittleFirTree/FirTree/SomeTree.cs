using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    public class SomeTree: BaseTree
    {
        public SomeTree() :base()
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine("Другое дерево.");
            base.ShowInfo();
        }
    }
}
