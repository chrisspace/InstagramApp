using InstagramApp.Models;
using InstagramApp.Models.Repositories;
using InstagramApp.Utility;
using InstagramApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotosPage : ContentPage
    {
       

        public PhotosPage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.PhotosPageViewModel;

        }
        /*async void Contacts_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactsPage());
        }*/

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
            //App.NavigationService.NavigateTo(PageNames.UpdatePhotoPage);
            
        }

        
    }
}