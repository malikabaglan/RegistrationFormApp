using System;
using Android.Content;
using Android.Graphics.Drawables;
using RegistrationForm;
using RegistrationForm.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(RoundedEntry), typeof(EntryRenderer_Droid))]
namespace RegistrationForm.Droid
{
    public class EntryRenderer_Droid:EntryRenderer
    {

  
    public EntryRenderer_Droid(Context context) : base(context)
    {

    }
    protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
    {
        base.OnElementChanged(e);

        if (e.OldElement == null)
        {

            // Control.SetBackgroundResource(Resource.Layout.rounded_shape);

            var gradientDrawable = new GradientDrawable();
            gradientDrawable.SetCornerRadius(60f);
            gradientDrawable.SetStroke(5, Android.Graphics.Color.DarkRed);
            gradientDrawable.SetColor(Android.Graphics.Color.DarkGray);
            Control.SetBackground(gradientDrawable);


            Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);


        }
    }
}
}
