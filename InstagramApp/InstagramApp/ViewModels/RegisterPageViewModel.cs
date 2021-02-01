using InstagramApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InstagramApp.ViewModels
{
    public class RegisterPageViewModel: BaseViewModel
    {
        public RegisterModel RegisterModel { get; set; } = new RegisterModel();

        private string _email;
        private string _password;

        public ICommand SignUpCommand { get; }

        public RegisterPageViewModel()
        {
            SignUpCommand = new Command(OnSignUpCommand);
        }

        private async void OnSignUpCommand() { }
        //{
        //    var firtsname = FirstnameEntry.Text;
        //    var lastname = LastnameEntry.Text;
        //    var email = Email;

        //    var password = PasswordEntry.Text;
        //    var confirmPassword = ConfirmPasswordEntry.Text;

        //    var stringCancel = "Try again!";
        //    var stringTitle = "Error!";
        //    var messageForUncompletedForm = "You have not completed all the required fields";
        //    var messageForDifferentPasswords = "You entered different password";


        //    if (firtsname == null || lastname == null || password == null || confirmPassword == null)
        //    {
        //        await App.Current.MainPage.DisplayAlert(stringTitle, messageForUncompletedForm, stringCancel);
        //    }

        //    else if (password != confirmPassword)
        //    {
        //        await App.Current.MainPage.DisplayAlert(stringTitle, messageForDifferentPasswords, stringCancel);
        //    }
        //    else
        //        await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
        //}


    }
}
