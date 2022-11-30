using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_Battle_Royale
{
    class Enemy
    {
        public void PickOpponent()
        {

        }

        public void Attack()
        {

        }

        public void RecieveDemage()
        {

        }

        public void HP()
        {

        }

        public void MaxHP()
        {

        }

        public bool IsAlive()
        {
            if (HP > 0)
                return false;
            else
                return true;
        }
    }

    class Fighter : Enemy
    {
       public string Name { get; set; }
    }

    class Knight : Fighter
    {

    }

    class Sorcerer
    {

    }
    class Beast
    {
        Paralyze()
        {

        }
    }
}
