using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    public interface IContactService
    {
        ContactViewModel CreateContact(ContactViewModel contact);
        bool DeleteContact(long id);
        List<ContactViewModel> GetAllContacts();
        ContactViewModel GetContactById(long id);
        ContactViewModel UpadateContact(ContactViewModel contact);
    }
}