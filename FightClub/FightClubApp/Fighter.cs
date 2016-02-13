using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp
{
    public enum PartOfBody
    {
        unknown,
        head,
        torso,
        legs
    }

    class Fighter
    {
        string name;
        PartOfBody blocked;
        PartOfBody hit;
        int hp;

        public Fighter()
        {
            Name = "Player";
            blocked = PartOfBody.unknown;
            hit = PartOfBody.unknown;
            hp = 100;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public PartOfBody Blocked
        {
            get { return blocked; }
            set { blocked = value; }
        }

        public PartOfBody Hit
        {
            get { return hit; }
            set { hit = value; }
        }

        public void GetHit(PartOfBody part)
        {
            hit = part ;
        }

        public void SetBlock(PartOfBody part)
        {
            blocked = part;
        }


        public static string ChoosePart(Fighter fighter)
        {
            string text = "";
            switch (fighter.blocked)
            {
                case PartOfBody.unknown:
                    break;
                case PartOfBody.head:
                    text += "голову";
                    break;
                case PartOfBody.torso:
                    text += "корпус";
                    break;
                case PartOfBody.legs:
                    text += "ноги";
                    break;
                default:
                    break;
            }
            return text;
        }

        public static string BattleResult( ref Fighter first, ref Fighter second)
        {
            string text = " ";

            if (first.hit == second.blocked) 
            {
                text += "Неудача! " + second.name + " мастерски защитил " + Fighter.ChoosePart(second);
                text += ". У " + second.name + " осталось " + second.HP + " жизней.";
            }

            else 
            {
                text += "Успех! " + second.name + " неудачно защищал " + Fighter.ChoosePart(second);
                second.HP -= 25;
                text += ". У " + second.name + " осталось " + second.HP + " жизней.";
            }
            return text;

        }

    }
}
