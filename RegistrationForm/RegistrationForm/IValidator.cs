using System;
namespace RegistrationForm.Validators.Contracts
{
    public interface IValidator
    {
        string Message { get; set; }
        bool Check(string value);
    }
}
