using InstagramApp.Models;
using InstagramApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApp.Services
{
    public class PhotoDataService: IPhotoDataService
    {
        public List<Photo> GetAllPhotos()
        {
            return PhotoRepository.Photos;
        }
        
        public void AddPhoto(Photo photo)
        {
            PhotoRepository.AddPhoto(photo);
        }


        public void DeletePhoto(Photo photo)
        {
            PhotoRepository.DeletePhoto(photo);
        }

        public void UpdatePhoto(Photo photo)
        {
            PhotoRepository.UpdatePhoto(photo);
        }
    }
}
