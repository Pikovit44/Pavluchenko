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
        int hp;

        public Fighter()
        {
            Name = "Player";
            blocked = PartOfBody.unknown;
            hp = 100;
        }

        public string Name
        {
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
       




    }
}
