using System;
using Xamarin.Forms;

namespace RegistrationForm.Validators.Contracts
{
    public interface IErrorStyle
    {
        void ShowError(View view, string message);
        void RemoveError(View view);
    }
}
