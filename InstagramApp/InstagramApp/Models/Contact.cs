using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InstagramApp.Models
{
    public class Contact
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private string _imageUrl { get; set; }
        private string _description { get; set; }

        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
            }
        }

        [MaxLength(100)]
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
            }
        }

        

    }
}
