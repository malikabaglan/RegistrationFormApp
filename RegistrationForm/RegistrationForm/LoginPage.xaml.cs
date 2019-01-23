using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RegistrationForm
{
    public partial class LoginPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
       
         //   if (emailAddress==null || UserLogin==null)
         if (string.IsNullOrEmpty(emailAddress.Text)||string.IsNullOrEmpty(UserLogin.Text ))
            {
                DisplayAlert("Error", "Email address and Password required", "OK");
            }
            else
            {
                Navigation.PushAsync(new AboutMePage());
            }
        }

        public LoginPage()
        {
           InitializeComponent();
        }
    }
}
