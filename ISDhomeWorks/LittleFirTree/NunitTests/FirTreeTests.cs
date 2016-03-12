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
        public void SetUp()
        {
            Forest forest = new Forest(PartOfYear.Winter); // вопрос по запуску
        }

        [Test]
        public void FormFirTreeForSeason()
        {
            Forest forest = new Forest(PartOfYear.Winter);
            forest.FirTreeBorn(); // ёлочка родилась (зимой. должна быть стройной).

            Shape form = forest.GetFormForIndex(0);
            Assert.AreEqual(Shape.Shapely, form);

            forest.NextSeason(); // весна
            // в описании ничего не указано по поводу формы ёлочки весной и осенью
            // стройность в эти сезоны не должна быть определена

            form = forest.GetFormForIndex(0);
            Assert.AreEqual(Shape.Unknown, form);

            forest.NextSeason(); // лето. ёлочка по условию опять стройная
            form = forest.GetFormForIndex(0);
            Assert.AreEqual(Shape.Shapely, form);

            forest.NextSeason(); // осень. стройность неизвестна
            form = forest.GetFormForIndex(0);
            Assert.AreEqual(Shape.Unknown, form);
        }

        [Test]
        public void ConditionFirTreeForSeason()
        {
            //цвет ёлочки меняется по сезонам аналогично форме
            Forest forest = new Forest(PartOfYear.Winter);
            forest.FirTreeBorn(); 

            Colour condition = forest.GetConditionForIndex(0);
            Assert.AreEqual(Colour.Green, condition);

            forest.NextSeason(); 
            condition = forest.GetConditionForIndex(0);
            Assert.AreEqual(Colour.Unknown, condition);

            forest.NextSeason(); 
            condition = forest.GetConditionForIndex(0);
            Assert.AreEqual(Colour.Green, condition);

            forest.NextSeason();
            condition = forest.GetConditionForIndex(0);
            Assert.AreEqual(Colour.Unknown, condition);
        }

        [Test]
        public void AgeFirTreeForSeason()
        {
            //при рождении ёлочки ее возраст = 0
            //с каждым новым сезоном возраст увеличивается на 0,25 года
            Forest forest = new Forest(PartOfYear.Winter);
            forest.FirTreeBorn();

            double age = forest.GetAgeForIndex(0);
            Assert.AreEqual(0, age);

            forest.NextSeason();
            forest.NextSeason();
            
            age = forest.GetAgeForIndex(0);
            Assert.AreEqual(0.5, age);
        }

        [Test]
        public void HeightFirTreeForSeason()
        {
            //при рождении ёлочки ее рост = 0
            //с каждым новым сезоном возраст увеличивается на 0,5 метра
            Forest forest = new Forest(PartOfYear.Winter);
            forest.FirTreeBorn();

            double height = forest.GetHeightForIndex(0);
            Assert.AreEqual(0, height);

            forest.NextSeason();
            forest.NextSeason();

            height = forest.GetHeightForIndex(0);
            Assert.AreEqual(1, height);
        }
        [Test]
        public void SeasonActuality()
        {
            Forest forest = new Forest(PartOfYear.Winter);
            //циклическая последовательность сезонов зима -> весна -> лето -> осень и тд.

            forest.NextSeason();
            Assert.AreEqual(PartOfYear.Spring, forest.ActualSeason);

            forest.NextSeason();
            Assert.AreEqual(PartOfYear.Summer, forest.ActualSeason);

            forest.NextSeason();
            Assert.AreEqual(PartOfYear.Autumn, forest.ActualSeason);

            forest.NextSeason();
            Assert.AreEqual(PartOfYear.Winter, forest.ActualSeason);
        }

        [Test]
        public void AgeWoodForSeason()
        {
            //при рождении леса его возраст = 0
            //с каждым новым сезоном возраст увеличивается на 0,25 года
            Forest forest = new Forest(PartOfYear.Winter);

            double age = forest.Age;
            Assert.AreEqual(0, age);

            forest.NextSeason();
            forest.NextSeason();

            age = forest.Age;
            Assert.AreEqual(0.5, age);
        }
    }
}
