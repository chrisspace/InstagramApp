using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InstagramApp.Models.Repositories
{
    public static class ContactRepository
    {
        public static List<Contact> Contacts { get; set; }


        // for displaying Enums as a string
        public static string GetDisplayName<T>(this T enumValue) where T : IComparable, IFormattable, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("Argument must be of type Enum");

            DisplayAttribute displayAttribute = enumValue.GetType()
                                                         .GetMember(enumValue.ToString())
                                                         .First()
                                                         .GetCustomAttribute<DisplayAttribute>();

            string displayName = displayAttribute?.GetName();

            return displayName ?? enumValue.ToString();
        }



        static ContactRepository()
        {
            DescriptionType relationship = DescriptionType.InaRelationship;
            DescriptionType free = DescriptionType.Free;
            DescriptionType complicated = DescriptionType.ItsComplicated;


            if (Contacts == null)
            {
                Contacts = new List<Contact>
                {
                    new Contact
                    {
                        Id=1,
                        Name="xristina",
                        Description=free.GetDisplayName(),
                        ImageUrl="istockphoto.jpg"
                    },
                    new Contact
                    {
                        Id=2,
                        Name="tina",
                        Description=relationship.GetDisplayName(),
                        ImageUrl="resources/drawable/istockphoto.jpg"
                    },
                    new Contact
                    {
                        Id=3,
                        Name="ifi",
                        Description=free.GetDisplayName(),
                        ImageUrl="istockphoto"
                    },
                    new Contact
                    {
                        Id=4,
                        Name="ntina",
                        Description=complicated.GetDisplayName(),
                        ImageUrl="istockphoto"
                    },
                     new Contact
                    {
                        Id=5,
                        Name="ntina",
                        Description=complicated.GetDisplayName(),
                        ImageUrl="istockphoto"
                    },
                      new Contact
                    {
                        Id=6,
                        Name="ntina",
                        Description=free.GetDisplayName(),
                        ImageUrl="istockphoto"
                    }

                };
            }
        }
        public static void DeleteContact(Contact contact)
        {
            Contacts.Remove(contact);
        }
    }
}
