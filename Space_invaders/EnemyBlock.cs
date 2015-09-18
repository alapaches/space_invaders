using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    class EnemyBlock
    {
        public List<SpaceShip> ships;
        public Vecteur2D position;
        public Size size;
        private Vecteur2D speedX;
        private Vecteur2D speedY;
        public bool alive
        {
            private set;
            get;
        }

       public EnemyBlock(Vecteur2D position)
        {

        }

    }
}
