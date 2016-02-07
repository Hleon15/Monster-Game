using System;
using System.Collections.Generic;

namespace Monsters
{
	public class Monster
	{
		private int health;
		private int attack;
		private static Random random = new Random (); //static makes it so that every single instance of Monster is using the same instance of random, 
														//instead of a new one being created each time an instance is created of Monster.


		public int Health
		{
			get
			{
				return health;
			}
			set
			{
				this.health = value;
			}
		}
		public int Attack
		{
			get
			{
				return attack;
			}
		}

		public Monster ()
		{
			GetMonsterStats (); //loads this when the monster is created
			Console.WriteLine (health);
			Console.WriteLine (attack);
		}
		public void GetMonsterStats() //sets the stats of the monster randomly
		{
				attack = random.Next (5, 11);
				health = random.Next (5, 11);
				

			
		}


	}
}

