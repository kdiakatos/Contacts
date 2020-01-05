using Contacts.Models;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public interface IContactRepository
    {
        Contact CreateContact(Contact contact);
        bool DeleteContact(long id);
        List<Contact> GetAllContacts();
        Contact GetContactById(long id);
        Contact UpdateContact(Contact contact);
    }
}