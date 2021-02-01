using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InstagramApp.Models.Repositories
{
    public class PhotoRepository
    {
        
        public static List<Photo> Photos { get; set; }
        
        static PhotoRepository()
        {
            if (Photos == null)
            {
                Photos = new List<Photo>
                {
                    new Photo
                    {
                        PhotoUrl="photoNature.jpg",
                        Description="Pure nature",
                        Location="Parnassos"

                    },
                    new Photo
                    {
                        PhotoUrl="swimmingPool.jpg",
                        Description="Pure nature",
                        Location="Parnassos"
                    },
                   
                    new Photo
                    {
                        PhotoUrl="athensPhoto.jpg",
                        Description="Pure nature",
                        Location="Parnassos"
                    },
                    
                     new Photo
                    {
                        PhotoUrl="photoNature.jpg",
                        Description="Pure nature",
                        Location="Parnassos"
                    },
                     new Photo
                    {
                        PhotoUrl="nafpaktosPhoto.jpg",
                        Description="Pure nature",
                        Location="Parnassos"
                    },
                     new Photo
                    {
                        PhotoUrl="istockphoto.jpg",
                        Description="Pure nature",
                        Location="Parnassos"
                    },
                    new Photo
                    {
                        PhotoUrl="cherryPie.jpg",
                        Description="Pure nature",
                        Location="Parnassos"
                    },
                    new Photo
                    {
                        PhotoUrl="athensPhoto.jpg",
                        Description="Pure nature",
                        Location="Parnassos"
                    },
                   
                    new Photo
                    {
                        PhotoUrl="swimmingPool.jpg",
                        Description="Pure nature",
                        Location="Parnassos"
                    }
                };
           }
        }

        

        public static void AddPhoto(Photo photo)
        {

            //photo.Id = Guid.NewGuid();
            //photo.PhotoUrl = "nafpaktosPhoto.jpg";
            //Photos.Add(photo);

            //Photo photo = new Photo
            //{

            //    photo.Id = Guid.NewGuid(),
            //    photo.PhotoUrl = "nafpaktosPhoto.jpg",
            //    Description = DescriptionRecipeEntry.Text
            //};

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Photo>();
                photo.Id = Guid.NewGuid();
                photo.PhotoUrl = "nafpaktosPhoto.jpg";
                //Photos.Add(photo);
                int rows = conn.Insert(photo);

                //if (rows > 0)
                //    DisplayAlert("Success", "Post inserted succesfully", "Ok");
                //else
                //    DisplayAlert("Failure", "Post failed to insert", "Ok");
            }

        }

        public static void UpdatePhoto(Photo photo)
        {
            var oldPhoto = Photos.Where(p => p.Id == photo.Id).FirstOrDefault();
            oldPhoto.PhotoUrl = photo.PhotoUrl;
            oldPhoto.Description = photo.Description;
            oldPhoto.Location =photo.Location;
        }

        public static void DeletePhoto(Photo photo)
        {
            Photos.Remove(photo);
        }


    }
}
