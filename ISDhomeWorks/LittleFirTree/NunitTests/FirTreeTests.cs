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
    //[TestFixture]
    //public class FirTreeTests
    //{
    //    Forest forest;
    //    [SetUp]
    //    public void SetUp()
    //    {
    //        forest = new Forest(PartOfYear.Winter);
    //        forest.FirTreeBorn(); 
    //    }

    //    [Test]
    //    public void FormFirTreeForSeason()
    //    {
    //        Shape form = forest.GetFormFirTree();
    //        Assert.AreEqual(Shape.Shapely, form);

    //        forest.NextSeason();
    //        form = forest.GetFormFirTree();
    //        Assert.AreEqual(Shape.Unknown, form);

    //        forest.NextSeason();
    //        form = forest.GetFormFirTree();
    //        Assert.AreEqual(Shape.Shapely, form);

    //        forest.NextSeason();
    //        form = forest.GetFormFirTree();
    //        Assert.AreEqual(Shape.Unknown, form);
    //    }

    //    [Test]
    //    public void ConditionFirTreeForSeason()
    //    {
    //        Color condition = forest.GetConditionFirTree();
    //        Assert.AreEqual(Color.Green, condition);

    //        forest.NextSeason(); 
    //        condition = forest.GetConditionFirTree();
    //        Assert.AreEqual(Color.Unknown, condition);

    //        forest.NextSeason(); 
    //        condition = forest.GetConditionFirTree();
    //        Assert.AreEqual(Color.Green, condition);

    //        forest.NextSeason();
    //        condition = forest.GetConditionFirTree();
    //        Assert.AreEqual(Color.Unknown, condition);
    //    }

    //    [Test]
    //    public void AgeFirTreeForSeason()
    //    {
    //        double age = forest.GetAgeFirTree();
    //        Assert.AreEqual(0, age);

    //        forest.NextSeason();
    //        forest.NextSeason();
            
    //        age = forest.GetAgeFirTree();
    //        Assert.AreEqual(0.5, age);
    //    }

    //    [Test]
    //    public void HeightFirTreeForSeason()
    //    {
    //        double height = forest.GetHeightFirTree();
    //        Assert.AreEqual(0, height);

    //        forest.NextSeason();
    //        forest.NextSeason();

    //        height = forest.GetHeightFirTree();
    //        Assert.AreEqual(1, height);
    //    }
    //    [Test]
    //    public void SeasonActuality()
    //    {
    //        Assert.AreEqual(PartOfYear.Winter, forest.ActualSeason);

    //        forest.NextSeason();
    //        Assert.AreEqual(PartOfYear.Spring, forest.ActualSeason);

    //        forest.NextSeason();
    //        Assert.AreEqual(PartOfYear.Summer, forest.ActualSeason);

    //        forest.NextSeason();
    //        Assert.AreEqual(PartOfYear.Autumn, forest.ActualSeason);

    //        forest.NextSeason();
    //        Assert.AreEqual(PartOfYear.Winter, forest.ActualSeason);
    //    }

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
    //}
}
