using InstagramApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace InstagramApp.ViewModels
{
    public class InfoPageViewModel:BaseViewModel
    {
        private int _counterContact=ContactRepository.Contacts.Count;
        private int _counterPhoto = PhotoRepository.Photos.Count;



        public event PropertyChangedEventHandler PropertyChanged;
        public int CounterContact
        {
            get => _counterContact;
            set
            {
                _counterContact = value;
                OnPropertyChanged("CounterContact");
            }
        }

        public int CounterPhoto
        {
            get => _counterPhoto;
            set
            {
                _counterPhoto = value;
                OnPropertyChanged("CounterPhoto");
                
            }
        }

  
    }
}
