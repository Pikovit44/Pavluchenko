using System;
using FightClubApp.Inerfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FightClubApp.FightersClasses;
using System.Threading.Tasks;

namespace FightClubApp.FightersClasses
{
    public class Player: IPlayer
    {
        protected string name = "Игрок";
        protected int hp = 100; // константа
        protected PartOfBody block = PartOfBody.unknown;
        protected PartOfBody hit = PartOfBody.unknown;
        protected int numberOfHits = 0;


        //вывод статистики +-
        //на fightClick сделать проверку успешности бота и игрока. эти данные перекинуть в статистику. 
       

        public void GetHit(PartOfBody part)
        {
            if(block != part)
            {
                if (hp > 20) 
                {
                    hp -= 20; // сделать константку
                    if (Wound != null) 
                    {
                        Wound(this, new MyEventArgs(hp, name, part, block));
                        numberOfHits++;
                    }
                }
                else
                {
                    hp = 0;
                    if (Death != null)
                    {
                        Death(this, new MyEventArgs(hp, name));
                    }
                }
            }
            else if (block == part)
                if (Block != null)
                {
                    Block(this, new MyEventArgs(hp, name, block));

                }
        }

        public void SetBlock(PartOfBody part)
        {
            block = part;
        }

        public string Name
        {
            get { return name; }
        }
        
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public PartOfBody BlockPart
        {
            get { return block; }
            set { block = value; }
        }
        public PartOfBody HitPart
        {
            get { return hit; }
            set { hit = value; }
        }
        public int NumberOfHit
        {
            get { return numberOfHits; }
        }

        public event EventHandler<MyEventArgs> Wound;
        public event EventHandler<MyEventArgs> Block;
        public event EventHandler<MyEventArgs> Death;
    }
}
