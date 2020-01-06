using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    public interface IContactService
    {
        /// <summary>
        /// Add new Contact 
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        ContactViewModel CreateContact(ContactViewModel contact);

        /// <summary>
        /// find contact and delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteContact(long id);
        List<ContactViewModel> GetAllContacts();

        /// <summary>
        /// get only user's contact
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ContactViewModel GetContactById(long id);

        /// <summary>
        /// find contact update and save
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        ContactViewModel UpadateContact(ContactViewModel contact);
    }
}