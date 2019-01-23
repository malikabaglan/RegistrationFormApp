using System;
using CoreGraphics;
using RegistrationForm;
using RegistrationForm.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(RoundedEntry), typeof(EntryRenderer_Ios))]
namespace RegistrationForm.iOS
{
    public class EntryRenderer_Ios:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {

                Control.Layer.CornerRadius = 40;
                Control.Layer.BorderWidth = 3f;
                Control.Layer.BorderColor = Color.DarkRed.ToCGColor();
                Control.Layer.BackgroundColor = Color.DarkGray.ToCGColor();


                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;

            }
        }
    }
}
