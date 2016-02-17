using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FightClubApp.FightersClasses;
using System.Threading.Tasks;

namespace FightClubApp.FightersClasses
{
    


    public interface IPlayer
    {
        string Name { get; }
        int HP { get; }
        void GetHit(PartOfBody part);
        void SetBlock(PartOfBody part);
        PartOfBody BlockPart { get; set; }
        PartOfBody HitPart { get; set; }
        event EventHandler<MyEventArgs> Wound;
        event EventHandler<MyEventArgs> Block;
        event EventHandler<MyEventArgs> Death;
    }

    public class Player: IPlayer
    {
        protected string name = "Игрок";
        protected int hp = 100;
        protected PartOfBody block = PartOfBody.unknown;
        protected PartOfBody hit = PartOfBody.unknown;


        public void GetHit(PartOfBody part)
        {
            if(block != part)
            {
                if (hp > 0)
                {
                    hp -= 25;
                    if (Wound != null) //?
                    {
                        Wound(this, new MyEventArgs(hp, name, part, block));
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

        public event EventHandler<MyEventArgs> Wound;
        public event EventHandler<MyEventArgs> Block;
        public event EventHandler<MyEventArgs> Death;
    }
}
