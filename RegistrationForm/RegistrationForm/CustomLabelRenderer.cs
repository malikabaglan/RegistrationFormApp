﻿using System;
using Xamarin.Forms;

namespace RegistrationForm
{
    public class CustomLabelRenderer : Label
    {


        public static readonly BindableProperty CurvedCornerRadiusProperty =
                  BindableProperty.Create(
                      nameof(CurvedCornerRadius),
                      typeof(double),
                      typeof(CustomLabelRenderer),
                      12.0);

        public double CurvedCornerRadius
        {
            get { return (double)GetValue(CurvedCornerRadiusProperty); }
            set { SetValue(CurvedCornerRadiusProperty, value); }
        }

        public static readonly BindableProperty CurvedBackgroundColorProperty =
            BindableProperty.Create(
                nameof(CurvedCornerRadius),
                typeof(Color),
                typeof(CustomLabelRenderer),
                Color.Default);

        public Color CurvedBackgroundColor
        {
            get { return (Color)GetValue(CurvedBackgroundColorProperty); }
            set { SetValue(CurvedBackgroundColorProperty, value); }
        }
    }
}