using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RegistrationForm
{
    public partial class TabbedProfessionPage : ContentPage
    {
        public TabbedProfessionPage()
        {
            InitializeComponent();
            this.BindingContext = new CheckBoxLogic();
        }
    }
}
