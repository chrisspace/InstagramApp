using InstagramApp.Models;
using InstagramApp.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InstagramApp.ViewModels
{
    public class UpdatePhotoPageViewModel:BaseViewModel
    {        
        private Photo _selectedPhoto;

        public Photo SelectedPhoto
        {
            get { return _selectedPhoto; }
            set
            {
                _selectedPhoto = value;
                OnPropertyChanged(nameof(SelectedPhoto));
            }
        }

        public ICommand SaveCommand { get; }
        public ICommand DeleteCommand { get; }

        public UpdatePhotoPageViewModel()
        {
            SelectedPhoto = new Photo();
            SaveCommand = new Command(OnSaveCommand);
            DeleteCommand = new Command(OnDeleteCommand);
        }
        
        private void OnSaveCommand()
        {
            if (SelectedPhoto.Id == Guid.Empty)
                App.PhotoDataService.AddPhoto(SelectedPhoto);
            else
                App.PhotoDataService.UpdatePhoto(SelectedPhoto);           

            MessagingCenter.Send(this, MessageNames.SelectedPhotoMessage, SelectedPhoto);
            App.NavigationService.GoBack();
        }

        public override void Initialize(object parameter)
        {
            if (parameter == null)
                SelectedPhoto = new Photo();
            else
                SelectedPhoto = parameter as Photo;
        }

        private void OnDeleteCommand()
        {
            App.PhotoDataService.DeletePhoto(SelectedPhoto);

            MessagingCenter.Send(this, MessageNames.SelectedPhotoMessage, SelectedPhoto);

            App.NavigationService.GoBack();
        }
    }
}
