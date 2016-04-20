using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Enums;
using FirTree;
using FirTree.Interfaces;

namespace NunitTests
{
    [TestFixture]
    public class FirTreeTests
    {
        IForest forest;
        IFirTree firTree;
        [SetUp]
        public void SetUp()
        {
            double deltaHeight = 1.2;
            int needleLength = 11;
            int numberOfCones = 24;
            forest = new FirTree.Forest();
            forest.BornFirTree(deltaHeight, needleLength, numberOfCones);
            firTree = forest.FirTrees[0];
        }

        [Test]
        public void FormFirTreeForSeason()
        {
            Nature.NextSeason();

            Shape form = firTree.Form;
            Assert.AreEqual(Shape.Shapely, form);

            Nature.NextSeason();

            form = firTree.Form;
            Assert.AreEqual(Shape.Shapely, form);
        }

        [Test]
        public void StateFirTreeForSeason()
        {
            Color state = firTree.State;
            Assert.AreEqual(Color.Green, state);
            
            Nature.NextSeason();
            Nature.NextSeason();

            state = firTree.State;
            Assert.AreEqual(Color.Green, state);
        }

        [Test]
        public void AgeFirTreeForSeason()
        {
            double age = firTree.Age;
            Assert.AreEqual(0, age);

            Nature.NextSeason();
            Nature.NextSeason();

            age = firTree.Age;
            Assert.AreEqual(0.5, age);
        }

        [Test]
        public void HeightFirTreeForSeason()
        {
            double height = firTree.Height;
            Assert.AreEqual(0, height);

            Nature.NextSeason();
            Nature.NextSeason();

            height = firTree.Height;
            Assert.AreEqual(2.4, height);

            Nature.NextSeason();
            Nature.NextSeason();
            Nature.NextSeason();

            height = firTree.Height;
            Assert.AreEqual(6, height);
        }

        [Test]
        public void SeasonActuality()
        {
            Assert.AreEqual(PartOfYear.Summer, Nature.actualSeason);

            Nature.NextSeason();

            Assert.AreEqual(PartOfYear.Autumn, Nature.actualSeason);

            Nature.NextSeason();
            Nature.NextSeason();

            Assert.AreEqual(PartOfYear.Spring, Nature.actualSeason);

        }

        //    [Test]
        //    public void AgeForestForSeason()
        //    {
        //        double age = forest.Age;
        //        Assert.AreEqual(0, age);

        //        forest.NextSeason();
        //        forest.NextSeason();

        //        age = forest.Age;
        //        Assert.AreEqual(0.5, age);
        //    }
    }
}
