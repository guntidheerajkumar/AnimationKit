using System;
using MyAnimationKit;
using UIKit;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			//myView.Tada(HandleDCAnimationFinished);
			//myView.Bounce(HandleDCAnimationFinished);
			//myView.Pulse(HandleDCAnimationFinished);
			//myView.Shake(HandleDCAnimationFinished);
			//myView.Swing(HandleDCAnimationFinished);
			//myView.SnapIntoView(this.View, DCAnimationDirection.Left);
			//myView.BounceIntoView(this.View, DCAnimationDirection.Left);
			//myView.ExpandIntoView(this.View, HandleDCAnimationFinished);
			//myView.Hinge(HandleDCAnimationFinished);
			//myView.Drop(HandleDCAnimationFinished);
			//myView.SetRotation(180f, 1f, HandleDCAnimationFinished);
		}

		void HandleDCAnimationFinished()
		{

		}
	}
}
