using InstagramApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApp.Services
{
    public interface IPhotoDataService
    {
        List<Photo> GetAllPhotos();

        void AddPhoto(Photo photo);

        void UpdatePhoto(Photo photo);
        void DeletePhoto(Photo photo);

    }
}
