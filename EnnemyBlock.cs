using System;
using System.Collections.Generic;
using System.Drawing;

namespace SpaceInvaders
{
	public class EnnemyBlock
	{
		List<SpaceShip> Ships;

		//public Vecteur2D position;
		public Size size;

		private Vecteur2D speedX;
		private Vecteur2D speedY;

		public bool alive
        {
            private set;
            get;
        }

		/*public EnnemyBlock (Vecteur2D position)
		{
			this.position = position;
		}*/

		public void AddLine(int width, int nbShips, int lives, Bitmap im)
		{
			
		}

		public void Draw(Graphics g)
		{
			
		}

		public void Move(double deltaT)
		{
			
		}
	}
}