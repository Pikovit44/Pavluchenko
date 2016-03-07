using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FightClubApp;
using FightClubApp.FightersClasses;

namespace NunitTestsNew
{
    [TestFixture]
    public class NunitTests
    {

        [SetUp]
        public void Init()
        {
            Player player = new Player();
        }

        [Test]
        public void TestBlock()
        {
            TestThis(PartOfBody.Head);
            TestThis(PartOfBody.Tors);
            TestThis(PartOfBody.Legs);
            TestThis(PartOfBody.Unknown);
        }

        private void TestThis(PartOfBody part)
        {
            Player player = new Player(); //SetUp?
            player.SetBlock(part);

            if (part == PartOfBody.Unknown)
            {
                Assert.That(PartOfBody.Unknown, Throws.InvalidOperationException);
            }
            else
            {
                Assert.AreEqual(player.BlockPart, part);
            }

        }

    }
    
}

