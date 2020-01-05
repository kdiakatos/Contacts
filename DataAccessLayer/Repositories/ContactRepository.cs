using Contacts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactContext _context;

        public ContactRepository(ContactContext context)
        {
            _context = context;
        }

        /// <summary>
        /// finds and shows all Contacts
        /// </summary>
        /// <returns></returns>
        public List<Contact> GetAllContacts()
        {
            var allcontacts = new List<Contact>();
            allcontacts = _context.Contacts.ToList();
            return allcontacts;
        }

        /// <summary>
        /// Add new Contact 
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public Contact CreateContact(Contact contact)
        {
            try
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                //foreach(var item in contactNumbers)
                //{
                //    item.
                //    item.Contact.ContactID = contact.ContactID;
                //}
                //_context.ContactNumbers.AddRange(contactNumbers);
                //_context.SaveChanges();

            }
            catch (Exception ex)
            {
                var x = ex;
            }
            return contact;
        }

        /// <summary>
        /// find contact and delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteContact(long id)
        {
            var deleteStatus = false;
            var dbRow = _context.Contacts.SingleOrDefault(c => c.ContactID == id);
            if (dbRow !=null)
            {
                _context.Contacts.Remove(dbRow);
                _context.SaveChanges();
                deleteStatus = true;
            }
            return deleteStatus;
        }

        /// <summary>
        /// find contact update and save
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public Contact UpdateContact(Contact contact)
        {
            var dbRow = _context.Contacts.SingleOrDefault(c => c.ContactID == contact.ContactID);
            if (dbRow != null)
            {
                dbRow.Email = contact.Email;
                dbRow.FirstName = contact.FirstName;
                dbRow.LastName = contact.LastName;
                dbRow.Address = contact.Address;
                dbRow.Phone1 = contact.Phone1;
                dbRow.Phone2 = contact.Phone2;
                dbRow.Phone3 = contact.Phone3;
                dbRow.Phone4 = contact.Phone4;
                _context.SaveChanges();
            }
            return contact;
        }
           
          
        

        /// <summary>
        /// get only user's contact
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetContactById(long id)
        {
            var result= _context.Contacts.SingleOrDefault(a => a.ContactID == id);
            return result;
        }
    }
}
