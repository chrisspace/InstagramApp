using DLToolkit.Forms.Controls;
using InstagramApp.Pages;
using InstagramApp.Services;
using InstagramApp.Utility;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramApp
{
    public partial class App : Application
    {
        public static PhotoDataService PhotoDataService { get; } = new PhotoDataService();
        public static ContactDataService ContactDataService { get; } = new ContactDataService();
        public static NavigationService NavigationService { get; } = new NavigationService();

        public static string DatabaseLocation = string.Empty;

        public App(string databaseLocation)
        {

            InitializeComponent();
            FlowListView.Init();

            NavigationService.Configure(PageNames.PhotosPage, typeof(PhotosPage));
            NavigationService.Configure(PageNames.LoginPage, typeof(LoginPage));
            NavigationService.Configure(PageNames.ContactsPage, typeof(ContactsPage));
            NavigationService.Configure(PageNames.RegisterPage, typeof(RegisterPage));
            NavigationService.Configure(PageNames.AddNewPhotoPage, typeof(AddNewPhotoPage));
            NavigationService.Configure(PageNames.UpdatePhotoPage, typeof(UpdatePhotoPage));
            NavigationService.Configure(PageNames.InfoPage, typeof(InfoPage));

            MainPage = new NavigationPage(new LoginPage());
            DatabaseLocation = databaseLocation;

        }

        //public App(string databaseLocation)
        //{
        //    InitializeComponent();

        //    MainPage = new NavigationPage(new LoginPage());
        //    DatabaseLocation = databaseLocation;

        //}

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
