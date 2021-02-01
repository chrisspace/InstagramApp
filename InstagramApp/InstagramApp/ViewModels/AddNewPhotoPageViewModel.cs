using InstagramApp.Models;
using InstagramApp.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InstagramApp.ViewModels
{
    public class AddNewPhotoPageViewModel:BaseViewModel
    {
        private Photo _newPhoto;

        public Photo NewPhoto
        {
            get => _newPhoto;
            set
            {
               _newPhoto = value;
                OnPropertyChanged(nameof(_newPhoto));
            }
        }

        public ICommand SavePhotoCommand { get; }


        public AddNewPhotoPageViewModel()
        {
            NewPhoto = new Photo();
            //var newPhoto= new Photo();
            SavePhotoCommand = new Command(OnSavePhotoCommand);
        }

        public override void Initialize(object parameter)
        {
            if (parameter == null)
                NewPhoto = new Photo();
            else
                NewPhoto = parameter as Photo;
        }


        private void OnSavePhotoCommand()
        {
            if (NewPhoto.Id == Guid.Empty)
                App.PhotoDataService.AddPhoto(NewPhoto);
            else
                App.PhotoDataService.UpdatePhoto(NewPhoto);

            MessagingCenter.Send(this, MessageNames.NewPhotoMessage, NewPhoto);

            App.NavigationService.GoBack();           
        }

    }
}
