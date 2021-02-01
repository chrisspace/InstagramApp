using InstagramApp.Models;
using InstagramApp.Models.Repositories;
using InstagramApp.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InstagramApp.ViewModels
{
    public class PhotosPageViewModel: BaseViewModel
    {

        private ObservableCollection<Photo> _photos;
        private Photo _selectedPhoto;

        public ICommand NewPhotoCommand { get; }
        public ICommand LoadCommand { get; }
        public ICommand GoToContacts { get; }
        public ICommand PhotoSelectedCommand { get; }


        public Photo SelectedPhoto
        {
            get { return _selectedPhoto; }
            set
            {
                _selectedPhoto = value;
                OnPropertyChanged("NewPhoto");
            }
        }
        public ObservableCollection<Photo> Photos
        {
            get => _photos;
            set
            {
                _photos = value;
                OnPropertyChanged("Photos");
            }
        }
        public PhotosPageViewModel()
        {
            Photos = new ObservableCollection<Photo>();
            //Photos = new ObservableCollection<Photo>(PhotoRepository.Photos);

            NewPhotoCommand = new Command(OnNewPhotoCommand);
            LoadCommand = new Command(OnLoadCommand);
            GoToContacts = new Command(OnGoToContacts);
            PhotoSelectedCommand = new Command<Photo>(OnPhotoSelectedCommand);

            MessagingCenter.Subscribe<AddNewPhotoPageViewModel, Photo>
                (this, MessageNames.SelectedPhotoMessage, OnPhotoChanged);

            //MessagingCenter.Subscribe<UpdatePhotoPageViewModel, Photo>
                //(this, MessageNames.SelectedPhotoMessage, OnPhotoChanged);
        }
        private void OnPhotoSelectedCommand(Photo photo)
        {
            App.NavigationService.NavigateTo(PageNames.UpdatePhotoPage, photo);
        }

        private void OnNewPhotoCommand()
        {            
            App.NavigationService.NavigateTo(PageNames.AddNewPhotoPage);
        }

      
        public void OnLoadCommand()
        {
            // Photos = new ObservableCollection<Photo>(PhotoRepository.Photos);
            Photos = new ObservableCollection<Photo>(App.PhotoDataService.GetAllPhotos());
        }

        private void OnPhotoChanged(AddNewPhotoPageViewModel sender, Photo photo)
        {
            //Pies = new ObservableCollection<Pie>(PieRepository.Pies);
            Photos = new ObservableCollection<Photo>(App.PhotoDataService.GetAllPhotos());
        }

        private void OnGoToContacts()
        {
            App.NavigationService.NavigateTo(PageNames.InfoPage);
        }



    }
}
