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
                var object1 = new LoginModel();
                object1.Name = emailAddress.Text;
                object1.Password = UserLogin.Text;

                
              Navigation.PushAsync(new AboutMePage(object1));
     



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
