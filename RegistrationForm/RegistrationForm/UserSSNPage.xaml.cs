using System;
using System.Collections.Generic;
using RegistrationForm.ViewModel;
using Xamarin.Forms;

namespace RegistrationForm
{
    public partial class UserSSNPage : MasterDetailPage
    {
        void DocumentsUpload_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new UserFileUploadPage());
        }

        void LicenseDetails_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new UserLicensesDetailPage());
        }

        void DateOfBirth_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new User_DateOfBirth_Page());
        }

        void Proffession_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new User_ProffessionPage());
        }

        void EducationDetails_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new User_EducationDetailsPage());
        }

        public UserSSNPage()
        {
            InitializeComponent();
            IsPresented = true;
           





        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new UserSSNumberPage());
        }

        void AddressDetails_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new UserAddressDetailsPage());
        }
    }
}
