using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FirTree;
using Enums;

namespace NunitTests
{
    [TestFixture]
    public class FirTreeTests
    {
        [SetUp]
        public void Init()
        {
            Forest forest = new Forest(PartOfYear.Winter);
            forest.FirTreeBorn();
        }

        [Test]
        public void FirTreeInfo()
        {
            Forest forest = new Forest(PartOfYear.Winter);
            forest.FirTreeBorn();
        }
    }
}
