using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree.Interfaces
{
    public interface IForest
    {
        void FirTreeBorn();
        void ShowFirTreesInfo();
        void ShowAllTreesInfo();
        List<FirTree> FirTrees { get; }
    }
}
