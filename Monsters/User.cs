using System;

namespace Monsters
{
	public class User
	{
		private int health = 100;
		private int damage;
		private int monstersKilled = 0;
		private int runAmmount = 0;

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

		public int Damage
		{
			get
			{
				return damage;
			}
		}
		public int MonstersKilled
		{
			get
			{
				return monstersKilled;
			}
			set
			{
				monstersKilled = value;
			}
		}

		public User ()
		{
			FindUserDamage ();
		}

		private void FindUserDamage()
		{
			Random r = new Random ();
			damage = r.Next (5, 11);

		}
		public bool AttackMonster(Monster m)
		{
			bool monsterDead = false;
			m.Health = m.Health - damage;
			this.health = this.health - m.Attack;
			if(m.Health <= 0)
			{
				monstersKilled++;
				return monsterDead = true;
			}
			else
			{
				return monsterDead;
			}
				
		}
		public bool DidWin()
		{
			if(monstersKilled == 13 && health >0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool UserDead()
		{
			if(health <= 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool RunCount()
		{
			runAmmount++;
			if(runAmmount == 3)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}

