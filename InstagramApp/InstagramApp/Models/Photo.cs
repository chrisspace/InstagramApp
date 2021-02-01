using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace InstagramApp.Models
{
    public class Photo:INotifyPropertyChanged
    {
        private Guid _id { get; set; }
        private string _photoUrl { get; set; }
        private string _location { get; set; }
        private string _description { get; set; }

        [PrimaryKey, AutoIncrement]
        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
            
        }
        public string PhotoUrl
        {
            get => _photoUrl;
            set
            {
                _photoUrl = value;
                RaisePropertyChanged(nameof(PhotoUrl));
            }

        }

        public string Location
        {
            get => _location;
            set
            {
                _location = value;
                RaisePropertyChanged(nameof(Location));
            }
        }

        [MaxLength(100)]
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
