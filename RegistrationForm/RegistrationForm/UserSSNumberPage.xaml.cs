using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace RegistrationForm
{
    public partial class UserSSNumberPage : ContentPage
    {


        public UserSSNumberPage()
        {
            InitializeComponent();
        }




        // void Handle_Clicked(object sender, System.EventArgs e)
        //{
        //  var ssn = ssnNum.Text;
        //var ssnPattern = "^\\d{3}-\\d{2}-\\d{4}$";
        // var ssnPatter = "^\\d{3}\\d{2}\\d{4}$";
        // if (Regex.IsMatch(ssn, ssnPatter)|| Regex.IsMatch(ssn, ssnPattern))
        // {
        //    ssnError.Text = "Good";

        // }


        //else
        //{
        //  ssnError.Text = "SSN number is incorrect";
        // }

        //  if(ssnNum.Text ==ssnConf.Text)
        // {
        // DisplayAlert("Success", "SSN Number sussesfully saved", "Ok");
        // }

        // else
        // {
        // ssnConfError.Text = "Ssn Number is not maching";
        // }


        // }


        void Handle_Clicked(object sender, System.EventArgs e)
        {
          if(ssnNum.Text==ssnConf.Text)
            {
                DisplayAlert("Success", "Data saved successfully", "OK");

            }
          else
            {

                DisplayAlert("Error", "Data sis not matching", "OK");

            }
        }
    }
}










//        public UserSSNumberPage()
//        {
//            InitializeComponent();
//       }
//   }
//}
