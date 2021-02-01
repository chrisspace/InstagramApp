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
    public partial class UpdatePhotoPage : ContentPage
    {
        public UpdatePhotoPage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.UpdatePhotoPageViewModel;
        }
    }
}