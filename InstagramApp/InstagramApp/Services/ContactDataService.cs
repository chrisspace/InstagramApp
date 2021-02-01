using InstagramApp.Models;
using InstagramApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApp.Services
{
    public class ContactDataService : IContactDataService
    {
        public List<Contact> GetAllContacts()
        {
            return ContactRepository.Contacts;
        }

        public void AddContact(Contact contact)
        {

        }

        public void DeleteContact(Contact contact)
        {
            ContactRepository.DeleteContact(contact);
        }


        public void UpdateContact(Contact contact)
        {

        }
    }
}
