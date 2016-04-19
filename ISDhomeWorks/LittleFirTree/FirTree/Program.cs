using Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest sherwood = new Forest();

            Nature.NextSeason();
            Nature.NextSeason();

            sherwood.FirTreeBorn();
            sherwood.ShowFirTreesInfo();
            
            Nature.NextSeason();

            sherwood.FirTreeBorn();

            Nature.NextSeason();

            sherwood.SomeTreeBorn();

            Nature.NextSeason();

            sherwood.ShowAllTreesInfo();






        }
    }
}
