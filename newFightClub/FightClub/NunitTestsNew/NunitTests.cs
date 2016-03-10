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
            BlockMethod(PartOfBody.Head);
            BlockMethod(PartOfBody.Tors);
            BlockMethod(PartOfBody.Legs);
            BlockMethod(PartOfBody.Unknown);
        }

        [Test]
        public void TestHit()
        {
            HitMethod(PartOfBody.Head);
            HitMethod(PartOfBody.Tors);
            HitMethod(PartOfBody.Legs);
        }

        

        private void BlockMethod(PartOfBody part)
        {
            Player player = new Player(); //SetUp?
            player.SetBlock(part);
            Assert.AreEqual(player.BlockPart, part);
          //Assert.That(PartOfBody.Unknown, Throws.InvalidOperationException);  
        }

        private void HitMethod(PartOfBody part)
        {
            Player player = new Player(); //SetUp?
            player.SetBlock(PartOfBody.Head);
            player.GetHit(part);

            if (PartOfBody.Head == part || PartOfBody.Unknown == part)
            {
                Assert.AreEqual(player.HP, (int)Constant.StartHP);
            }
            else
            {
                Assert.AreEqual(player.HP, (int)Constant.StartHP - (int)Constant.WoundHP);
            }

        }

    }
    
}

