using System;
using System.Collections.Generic;

namespace Monsters
{
	public class MonsterList
	{

		private List<Monster> allMonsters = new List<Monster>();

		public List<Monster> AllMonsters
		{
			get
			{
				return allMonsters;
			}
		}

		public MonsterList ()
		{
			for(int i = 0; i < 13; i++)
			{
				Monster monster = new Monster ();
				AddMonster (monster);
			}
		}
		public void AddMonster(Monster m)
		{
			allMonsters.Add (m);
		}


	}
}

