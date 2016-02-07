// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Monsters
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton AttackButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel EnemyDamageLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel EnemyHealthLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel RemainingRoundsLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel RemainingRunsLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton RunButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel UserDamageLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel UserHealthLabel { get; set; }

		[Action ("AttackButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void AttackButton_TouchUpInside (UIButton sender);

		[Action ("RunButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void RunButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (AttackButton != null) {
				AttackButton.Dispose ();
				AttackButton = null;
			}
			if (EnemyDamageLabel != null) {
				EnemyDamageLabel.Dispose ();
				EnemyDamageLabel = null;
			}
			if (EnemyHealthLabel != null) {
				EnemyHealthLabel.Dispose ();
				EnemyHealthLabel = null;
			}
			if (RemainingRoundsLabel != null) {
				RemainingRoundsLabel.Dispose ();
				RemainingRoundsLabel = null;
			}
			if (RemainingRunsLabel != null) {
				RemainingRunsLabel.Dispose ();
				RemainingRunsLabel = null;
			}
			if (RunButton != null) {
				RunButton.Dispose ();
				RunButton = null;
			}
			if (UserDamageLabel != null) {
				UserDamageLabel.Dispose ();
				UserDamageLabel = null;
			}
			if (UserHealthLabel != null) {
				UserHealthLabel.Dispose ();
				UserHealthLabel = null;
			}
		}
	}
}
