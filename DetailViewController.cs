using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class DetailViewController : UIViewController
    {
        public float bmi = 21.5f;

        public DetailViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            EvaluateBMI();
        }

        void EvaluateBMI()
        {
            string result = String.Empty;

            if (bmi <= 16)
                result = "Very Low";
            else if (bmi < 18.5)
                result = "Low";
            else if (bmi < 25)
                result = "Normal";
            else if (bmi < 30)
                result = "High";
            else
                result = "Too Hight";

            resultLabel.Text = result;
        }
    }
}
