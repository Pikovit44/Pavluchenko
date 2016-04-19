using FirTree.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
using FirTree.Factory;

namespace FirTree
{
    public class Forest: IForest
    {
        List <FirTree> firTrees;
        List<BaseTree> allTrees;

        double age;
        const double DeltaAge = 0.25;
        string actualSeason;

        public Forest ()
        {
            firTrees = new List<FirTree>();
            allTrees = new List<BaseTree>();
            age = 0;
            Nature.changeSeason += Nature_changeSeason;
        }

        private void Nature_changeSeason(object sender, EventArgs e)
        {
            age += DeltaAge;
            actualSeason =  DiscriptionHelper.GetDescription(Nature.actualSeason);
        }

        public List<FirTree> FirTrees
        { get { return firTrees; } }

        public List<BaseTree> AllTrees
        { get { return allTrees; } }
        
        public double Age
        { get { return age; } }

        public void FirTreeBorn()
        {
            FirTree ft = (FirTree)TreeCreator.Create(TreeType.FirTree);
            allTrees.Add(ft); 
        }

        public void SomeTreeBorn()
        {
            SomeTree st = (SomeTree)TreeCreator.Create(TreeType.SomeTree);
            allTrees.Add(st);
        }

        public void ShowFirTreesInfo()
        {
            Console.WriteLine(actualSeason);
            for (int i = 0; i < allTrees.Count; i++)
            {
                if (allTrees[i] is FirTree)
                {
                    allTrees[i].ShowInfo();
                }
            }
            Console.ReadLine();
        }

        public void ShowAllTreesInfo()
        {
            Console.WriteLine(actualSeason);
            foreach (var tree in allTrees)
            {
                tree.ShowInfo();
            }
        }

    }
}
