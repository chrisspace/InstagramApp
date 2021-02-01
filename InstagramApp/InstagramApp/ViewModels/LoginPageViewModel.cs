using InstagramApp.Helpers;
using InstagramApp.Models;
using InstagramApp.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace InstagramApp.ViewModels
{
    public class LoginPageViewModel:BaseViewModel
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string _email;
        private string _password;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }

        public LoginPageViewModel()
        {
            RegisterCommand = new Command(OnRegisterCommand);
            LoginCommand = new Command(OnLoginCommand);
        }


        private void OnRegisterCommand()
        {
            App.NavigationService.NavigateTo(PageNames.RegisterPage);
        }


        static int attempt = 3;
        
        private void OnLoginCommand()
        {
            
            
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
                App.Current.MainPage.DisplayAlert(MessageNames.messageEmptyValues, MessageNames.messageToEnterCredentials, MessageNames.messageOk);
            else
            {
                if (Email == "a@g.com" && Password == "1")
                {
                    App.Current.MainPage.DisplayAlert(MessageNames.messageSuccessLogin, "", MessageNames.messageOk);
                    App.NavigationService.NavigateTo(PageNames.ContactsPage);
                }
                else if(attempt>1)
                {
                    attempt--;
                    var message = $"You have only {attempt} more attempts";
                    App.Current.MainPage.DisplayAlert(MessageNames.messageFailLogin, message, MessageNames.messageOk);
                }
                else
                {
                    var message = "You have given 3 times invalid password";
                    App.Current.MainPage.DisplayAlert("Account blocked", message, "Try later!");
                }                   
            }
        }

        
    }
}
