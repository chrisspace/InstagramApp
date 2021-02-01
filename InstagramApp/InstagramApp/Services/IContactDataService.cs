using InstagramApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApp.Services
{
    interface IContactDataService
    {
        List<Contact> GetAllContacts();

        void AddContact(Contact contact);

        void UpdateContact(Contact contact);
        void DeleteContact(Contact contact);
    }
}
