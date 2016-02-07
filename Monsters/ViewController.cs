using System;

using UIKit;

namespace Monsters
{
	public partial class ViewController : UIViewController
	{
		//FIELDS

		private int runButtonPressed = 0;
		private User user = new User();
		private MonsterList monsterList = new MonsterList();

		//CONSTRUCTOR 

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad () //what runs first. This or above.
		{
			base.ViewDidLoad ();
			updateMonsterStats ();
			updateUserStats ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
		private void updateMonsterStats()
		{
			EnemyDamageLabel.Text = monsterList.AllMonsters[user.MonstersKilled].Attack.ToString();
			EnemyHealthLabel.Text = monsterList.AllMonsters [user.MonstersKilled].Health.ToString();
			RemainingRoundsLabel.Text = user.MonstersKilled + "/13";
		}
		private void updateUserStats()
		{
			UserHealthLabel.Text = user.Health.ToString();
			UserDamageLabel.Text = user.Damage.ToString();
		}

		//BUTTONS 

		partial void AttackButton_TouchUpInside (UIButton sender)
		{
			user.AttackMonster(monsterList.AllMonsters[user.MonstersKilled]);
			if(user.DidWin)
			{
				monsterList.AllMonsters[user.MonstersKilled - 1].Health = 0;
				EnemyHealthLabel.Text = monsterList.AllMonsters[user.MonstersKilled - 1].Health.ToString();
				UIAlertView alert = new UIAlertView("Game Over","You won!",null,"Quit",null);
				alert.Show();
			}
			else if(user.UserDead)
			{
				UIAlertView alert = new UIAlertView("Game Over","You Died!",null,"Quit",null);
				alert.Show();
			}
			else
			{
			updateUserStats();
			updateMonsterStats();
			}

		}

		partial void RunButton_TouchUpInside (UIButton sender) //need to disable button
		{
			runButtonPressed++;
			RemainingRunsLabel.Text = runButtonPressed + "/3";
			user.MonstersKilled++;
			if(user.DidWin)
			{
				monsterList.AllMonsters[user.MonstersKilled - 1].Health = 0;
				EnemyHealthLabel.Text = monsterList.AllMonsters[user.MonstersKilled - 1].Health.ToString();
				UIAlertView alert = new UIAlertView("Game Over","You won!",null,"Quit",null);
				alert.Show();
			}
			else
			{
			updateMonsterStats();
			}
			if(user.RunCount)
			{
				UIAlertView alert = new UIAlertView("Error","Out of runs",null,"Quit",null);
				alert.Show();
				RunButton.Enabled = false;

			}	


		}

	}
}

