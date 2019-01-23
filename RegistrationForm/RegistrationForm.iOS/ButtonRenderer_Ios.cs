using System;
using CoreAnimation;
using CoreGraphics;
using RegistrationForm;
using RegistrationForm.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(CustomButtonRenderer), typeof(ButtonRenderer_Ios))]
namespace RegistrationForm.iOS
{
    public class ButtonRenderer_Ios:ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
               // Control.BackgroundColor = UIColor.FromRGB(220, 280, 455);
              //  Layer.CornerRadius = 5;
               // Layer.BorderWidth = 10;
                //Layer.ShadowColor = UIColor.Gray.CGColor;
              // Layer.ShadowOffset = new CGSize(90, 90);
                //Layer.ShadowOpacity = 90;
                //Layer.ShadowPath = UIBezierPath.FromRect(Layer.Bounds).CGPath;
                //Layer.MasksToBounds = true;
                Control.Layer.CornerRadius = 40;
                Control.Layer.BorderWidth = 3f;
                Control.Layer.BorderColor = Color.DarkRed.ToCGColor();
               // Control.Layer.BackgroundColor = Color.DarkGray.ToCGColor();
                
                
              //  Control.LeftView = new UIView(new CGRect(0, 0, 10, 0));
                // Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;

          





            }
        }
    }
}
