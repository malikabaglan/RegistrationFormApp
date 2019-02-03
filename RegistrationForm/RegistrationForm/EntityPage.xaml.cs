using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace RegistrationForm
{
    public partial class EntityPage : PopupPage
    {
        public EntityPage()
        {
            InitializeComponent();
            Random generator = new Random();
            String entity = generator.Next(0, 999999).ToString("D6");

            idNumber.Text = entity;
        }
    }
}
