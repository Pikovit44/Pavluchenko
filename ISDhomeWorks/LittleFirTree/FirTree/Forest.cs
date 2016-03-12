using FirTree.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;

namespace FirTree
{
    public class Forest: IForest
    {
        List<FirTree> firTrees;
        PartOfYear actualSeason;
        double age;
        
        public Forest (PartOfYear season)
        {
            age = 0;
            actualSeason = season;
            firTrees = new List<FirTree>();
        }

        public PartOfYear ActualSeason
        { get { return actualSeason; } }

        public double Age
        { get { return age; } }

        public void FirTreeBorn()
        {
            firTrees.Add(new FirTree(this));
        }
        
        public void NextSeason()
        {
            age += 0.25;
            switch (actualSeason)
            {
                case PartOfYear.Spring:
                    actualSeason = PartOfYear.Summer;
                    break;

                case PartOfYear.Summer:
                    actualSeason = PartOfYear.Autumn;
                    break;

                case PartOfYear.Autumn:
                    actualSeason = PartOfYear.Winter;
                    break;

                case PartOfYear.Winter:
                    actualSeason = PartOfYear.Spring;
                    break;
                default:
                    break;
            }

            foreach (FirTree ft in firTrees)
            {
                ft.Growth();
            }
        }

        public void NextYear()
        {
            for (int i = 0; i < 4; i++)
            {
                NextSeason();
            }
        }

        public Shape GetFormForIndex(int index)
        {
            return firTrees[index].Form;
        }

        public Colour GetConditionForIndex(int index)
        {
            return firTrees[index].Condition;
        }

        public double GetAgeForIndex(int index)
        {
            return firTrees[index].Age;
        }

        public double GetHeightForIndex(int index)
        {
            return firTrees[index].Height;
        }

        public void ShowFirTreesInfo()
        {
            Console.WriteLine("Возраст леса на данный момент: {0}", age);
            Console.WriteLine("Сезон: {0}", GetDescription(actualSeason));

            for (int i = 0; i < firTrees.Count; i++)
            {
                Console.WriteLine("Информация о ёлочке #{0}:", i + 1);
                Console.WriteLine("Форма: {0}.", GetDescription(firTrees[i].Form));
                Console.WriteLine("Цвет: {0}.", GetDescription(firTrees[i].Condition));
                Console.WriteLine("Высота: {0} м.", firTrees[i].Height);
                Console.WriteLine("Возраст: {0} года.", firTrees[i].Age);
                Console.WriteLine();
            }
            Console.ReadLine();
        }


        static string GetDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
                  (DescriptionAttribute[])fi.GetCustomAttributes(
                  typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }


    }
}
