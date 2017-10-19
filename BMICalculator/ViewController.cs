using System;
using UIKit;

namespace BMICalculator
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
            // Perform any additional setup after loading the view, typically from a nib.

            calculateButton.TouchUpInside+= CalculateButton_TouchUpInside;
        }

        void CalculateButton_TouchUpInside(object sender, EventArgs e)
        {
            float height = float.Parse(heightTextField);
            float weight = float.Parse(weightTextField);

            float bmi = (height / (weight ));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
