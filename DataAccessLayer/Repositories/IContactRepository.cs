using Contacts.Models;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public interface IContactRepository
    {
        /// <summary>
        /// Add new Contact 
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        Contact CreateContact(Contact contact);

        /// <summary>
        /// find contact and delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteContact(long id);

        /// <summary>
        /// finds and shows all Contacts
        /// </summary>
        /// <returns></returns>
        List<Contact> GetAllContacts();

        /// <summary>
        /// get only user's contact
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Contact GetContactById(long id);

        /// <summary>
        /// find contact update and save
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        Contact UpdateContact(Contact contact);
    }
}