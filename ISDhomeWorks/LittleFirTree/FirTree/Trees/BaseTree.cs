using Enums;
using FirTree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    public abstract class BaseTree : ITree
    {
        const double DeltaAge = 0.25;
        protected double deltaHeight;

        #region Properties

        public Color State
        { get; protected set; }

        public Shape Form
        { get; protected set; }

        public double Height
        { get; protected set; }

        public double Age
        { get; protected set; }

        public int Number
        { get; protected set; }

        #endregion

        public BaseTree()
        {
            Nature.changeSeason += Nature_changeSeason;
        }

        private void Nature_changeSeason(object sender, EventArgs e)
        {
            Growth();
        }

        protected virtual void Growth()
        {
            Age += DeltaAge;
            Height += deltaHeight;
        }
    }
}
