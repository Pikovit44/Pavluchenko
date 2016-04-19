using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    public abstract class BaseTree
    {
        protected Color state;
        protected Shape form;
        protected double height;
        protected double age;

        public BaseTree()
        {
            height = 0;
            age = 0;
        }

        #region Properties

        public Color State
        { get { return state; } }

        public Shape Form
        { get { return form; } }

        public double Height
        { get { return height; } }

        public double Age
        { get { return age; } }

        #endregion

        public virtual void ShowInfo()
        {
            Console.WriteLine("Форма: {0}", DiscriptionHelper.GetDescription(form));
            Console.WriteLine("Цвет: {0}", DiscriptionHelper.GetDescription(state));
            Console.WriteLine("Высота: {0} м", height);
            Console.WriteLine("Возраст: {0} года", age);
            Console.WriteLine();
        }

        protected virtual void Growth()
        {

        }
    }
}
