using InstagramApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApp.Utility
{
    public class ViewModelLocator
    {
        public static ContactPageViewModel ContactPageViewModel { get; set; } = new ContactPageViewModel();
        public static LoginPageViewModel LoginPageViewModel { get; set; } = new LoginPageViewModel();
        public static PhotosPageViewModel PhotosPageViewModel { get; set; } = new PhotosPageViewModel();
        public static RegisterPageViewModel RegisterPageViewModel { get; set; } = new RegisterPageViewModel();
        public static AddNewPhotoPageViewModel AddNewPhotoPageViewModel { get; set; } = new AddNewPhotoPageViewModel();
        public static UpdatePhotoPageViewModel UpdatePhotoPageViewModel { get; set; } = new UpdatePhotoPageViewModel();
        public static InfoPageViewModel InfoPageViewModel { get; set; } = new InfoPageViewModel();


    }
}
