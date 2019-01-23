using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RegistrationForm
{
    public partial class MainPage : ContentPage
    {
       

       async void Handle_Clicked(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new LoginPage());
        }
        public MainPage()
        {
            InitializeComponent();
        }

    }
}
