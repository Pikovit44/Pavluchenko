using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree.Factory
{
    public static class TreeCreator
    {
        public static BaseTree Create(TreeType type)
        {
            if (type == TreeType.FirTree) //swich in future
            {
                return new FirTree();
            }
            else
            {
                return new SomeTree(); 
            }

        }
    }
}
