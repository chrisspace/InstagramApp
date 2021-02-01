using InstagramApp.Helpers;
using InstagramApp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.RegisterPageViewModel;
        }



        async void SignUpButtonClicked(object sender, EventArgs e)
        {
            var firstname = FirstnameEntry.Text;
            var lastname = LastnameEntry.Text;
            var email = EmailEntry.Text;

            var password = PasswordEntry.Text;
            var confirmPassword = ConfirmPasswordEntry.Text;

            var stringCancel = "Try again!";
            var stringTitle = "Error!";
            var messageForUncompletedForm = "You have not completed all the required fields";
            var messageForDifferentPasswords = "You entered different password";


            if (firstname == null || lastname == null || password == null || confirmPassword == null)
            {
                await App.Current.MainPage.DisplayAlert(stringTitle, messageForUncompletedForm, stringCancel);
            }

            else if (password != confirmPassword)
            {
                await App.Current.MainPage.DisplayAlert(stringTitle, messageForDifferentPasswords, stringCancel);
            }
            else
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
    
    }
}