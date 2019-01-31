using System;
using System.Collections.Generic;
using RegistrationForm.ViewModel;
using Xamarin.Forms;

namespace RegistrationForm
{
    public partial class TabbedExperiencePage : ContentPage
    {

        public TabbedExperiencePage()
        {
            InitializeComponent();
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var vm = BindingContext as MainViewModal;
            var product = e.Item as Product;
            vm.HideOrShowProduct(product);
        }


    }
}
