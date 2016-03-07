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
        [Test]
        public void TestBlock()
        {
            Player player = new Player(); // in future setup

            player.SetBlock(PartOfBody.Head);
            Assert.AreEqual(player.BlockPart, PartOfBody.Head);

            player.SetBlock(PartOfBody.Tors);
            Assert.AreEqual(player.BlockPart, PartOfBody.Tors);

            player.SetBlock(PartOfBody.Legs);
            Assert.AreEqual(player.BlockPart, PartOfBody.Legs);

            player.SetBlock(PartOfBody.Unknown);
            Assert.That(PartOfBody.Unknown, Throws.InvalidOperationException);

        }

        [Test]
        public void TestHit()
        {

        }


    }
}
