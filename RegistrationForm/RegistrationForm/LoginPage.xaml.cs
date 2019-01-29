using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RegistrationForm
{
public partial class LoginPage : ContentPage
    {


     
        User user;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
       
     
         if (string.IsNullOrEmpty(emailAddress.Text)||string.IsNullOrEmpty(UserLogin.Text ))
            {
                DisplayAlert("Error", "Email address and Password required", "OK");
            }
            else
            {
              Navigation.PushAsync(new AboutMePage(emailAddress.Text));
     



                User.Register(user);
}

        }

        public LoginPage()
        {
           InitializeComponent();

            InitializeComponent();
            user = new User();

        }
    }

   
}
