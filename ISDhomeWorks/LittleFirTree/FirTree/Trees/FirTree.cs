using Enums;
using FirTree.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    public class FirTree: BaseTree, IFirTree  
    {
        const double FirTreeDeltaHeight = 0.5;
        const double FirTreeDeltaAge = 0.25;
        
        public FirTree() : base()
        {
            ConditionAndFormChange();
            Nature.changeSeason += Nature_changeSeason;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Ёлочка.");
            base.ShowInfo();
        }

        private void Nature_changeSeason(object sender, EventArgs e)
        {
            Growth();
        }

        protected override void Growth()
        {
            height += FirTreeDeltaHeight;
            age += FirTreeDeltaAge;
            ConditionAndFormChange();
        }
        
        private void ConditionAndFormChange()
        {
            if (Nature.actualSeason == PartOfYear.Autumn || Nature.actualSeason == PartOfYear.Spring)
            {
                state = Color.Unknown;
                form = Shape.Unknown;
            }
            else
            {
                state = Color.Green;
                form = Shape.Shapely;
            }
        }
    }
}
