using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RegistrationForm
{
    public partial class AboutMePage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(firstName.Text) || string.IsNullOrEmpty(lastName.Text))
            {
                DisplayAlert("Error", "Enter all required fields", "OK");
            }
            else
            {
                Navigation.PushAsync(new UserSSNPage());
        
               
              
            }





        }

        public AboutMePage(LoginModel loginModel)
        {
            InitializeComponent();
            mainLabel.Text = loginModel.Name;
            pswLbl.Text = loginModel.Password;

        }


    }
}
