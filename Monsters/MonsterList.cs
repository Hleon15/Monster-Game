using System;
using System.Collections.Generic;

namespace Monsters
{
	public class MonsterList
	{
		//FIELDS

		private List<Monster> allMonsters = new List<Monster>();

		//CONSTRUCTORS

		public MonsterList ()
		{
			for(int i = 0; i < 13; i++)
			{
				Monster monster = new Monster ();
				AddMonster (monster);
			}
		}

		//FIELD PROPERTIES

		public List<Monster> AllMonsters
		{
			get
			{
				return allMonsters;
			}
		}
			
		//METHODS 

		public void AddMonster(Monster m)
		{
			allMonsters.Add (m);
		}


	}
}

