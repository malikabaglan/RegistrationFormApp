//using System;
//using System.Runtime.Remoting.Contexts;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;

//using Android.Graphics.Drawables;
//using Android.Util;
//using RegistrationForm;
//using RegistrationForm.Droid;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.Android;
//[assembly: ExportRenderer(typeof(CustomLabelRenderer), typeof(LabelRenderer_Droid))]
//namespace RegistrationForm.Droid
//{
//    public class LabelRenderer_Droid:LabelRenderer


//    {
//        //public LabelRenderer_Droid(System.Runtime.Remoting.Contexts.Context context) : base(context)
//        //{

//        //}


//        private GradientDrawable _gradientBackground;

       

//        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
//        {
//            base.OnElementChanged(e);
//            var view = (CustomLabelRenderer)Element;
//            if (view == null) return;
//            // creating gradient drawable for the curved background
//            _gradientBackground = new GradientDrawable();
//            _gradientBackground.SetShape(ShapeType.Rectangle);
//            _gradientBackground.SetColor(view.CurvedBackgroundColor.ToAndroid());

//            // Thickness of the stroke line
//            _gradientBackground.SetStroke(4, view.CurvedBackgroundColor.ToAndroid());

//            // Radius for the curves
//            _gradientBackground.SetCornerRadius(DpToPixels(this.Context,Convert.ToSingle(view.CurvedCornerRadius)));

//            // set the background of the label
//            Control.SetBackground(_gradientBackground);
//        }
//        //Px to Dp Conver
//        public static float DpToPixels(System.Runtime.Remoting.Contexts.Context context, float valueInDp)
//        {
//           DisplayMetrics metrics = context.Resources.DisplayMetrics;
//            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
//        }
//    }
//}
