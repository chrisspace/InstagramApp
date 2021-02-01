using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InstagramApp.Services
{
    public interface INavigationService
    {
        Page MainPage { get; }
        void Configure(string key, Type pageType);
        void GoBack();
        void NavigateTo(string pageKey, object parameter=null);

    }
}
