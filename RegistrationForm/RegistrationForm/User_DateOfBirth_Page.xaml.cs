using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RegistrationForm
{
    public partial class User_DateOfBirth_Page : ContentPage
    {
      
        public User_DateOfBirth_Page()
        {
            InitializeComponent();
        }

        void Handle_DateClicked(object sender, XamForms.Controls.DateTimeEventArgs e)
        {

            MainLabel.Text = "Selected date " + e.DateTime.ToLongDateString();
        }

        void Handle_DateSelected(object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
            MainLabel.Text = "Selected date " + e.NewDate.ToLongDateString();
        }
    }
}
