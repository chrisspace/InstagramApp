using InstagramApp.Models;
using InstagramApp.Utility;
using InstagramApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();

            // Apply view model locators in order to have looser coupling between View and ViewModel.
            BindingContext = ViewModelLocator.ContactPageViewModel;
            

        }


        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            mainList.ItemsSource = ((ContactPageViewModel)BindingContext).Contacts.Where(
              c => c.Name.ToUpper().Contains(e.NewTextValue.ToUpper()) || c.Description.ToUpper().Contains(e.NewTextValue.ToUpper()));
        }



        private Contact _selectedContact;

        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
            }
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            App.ContactDataService.DeleteContact(SelectedContact);

            MessagingCenter.Send(this, MessageNames.SelectedPhotoMessage, SelectedContact);

            App.NavigationService.GoBack();
        }
    }
}