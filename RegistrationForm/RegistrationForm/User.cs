﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm
{
    public class User // : INotifyPropertyChanged
    {
        //public string Id { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }

        private string id;

        public string Id
        {
            get { return id; }
            set
            {
               // id = value;
                //OnPropertyChanged("Id");
            }
        }



        private string email;           

        public string Email
        {
            get { return email; }
            set
            {
              //  email = value;
              //  OnPropertyChanged("Email");
            }
        }



        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                //password = value;
               // OnPropertyChanged("Password");
            }
        }


        //public event PropertyChangedEventHandler PropertyChanged;
        //private void OnPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //}


        //public static async Task<bool> Login(string email, string password)
        //{
        //    bool emailAddress = string.IsNullOrEmpty(email);
        //    bool UserLogin = string.IsNullOrEmpty(password);

        //    if (UserLogin || UserLogin)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        var user = (await App.MobileService.GetTable<User>().Where(u => u.Email == email).ToListAsync()).FirstOrDefault();

        //        if (user != null)
        //        { 
        //            App.user = user;
        //            if (user.Password == password)

        //                return true;
        //            else
        //                return false;
        //        }
        //        else    
        //        {
        //            return false;
        //        }

        //    }S
        //}
        public static async void Register(User user)
        {
         //await App.MobileService.GetTable<User>().InsertAsync(user);
        }
    }
}
