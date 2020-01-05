using AutoMapper;
using BusinessLayer.Models;
using Contacts.Models;
using DataAccessLayer;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace BusinessLayer.Services
{
    public class ContactService : IContactService
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactrepository;

        public ContactService(IContactRepository contactrepository, IMapper mapper)
        {
            _contactrepository = contactrepository;
            _mapper = mapper;

        }

        public List<ContactViewModel> GetAllContacts()
        {
            var dbResult = _contactrepository.GetAllContacts();
            var contactList = _mapper.Map<List<ContactViewModel>>(dbResult);
            
            return contactList;
        }

        public ContactViewModel GetContactById(long id)
        {
            var dbResult = _contactrepository.GetContactById(id);
            var contact = _mapper.Map<ContactViewModel>(dbResult);
            return contact;
        }

        public ContactViewModel CreateContact(ContactViewModel contact)
        {
            var dbRow = _mapper.Map<Contact>(contact);
            var response = _contactrepository.CreateContact(dbRow);
            var result = _mapper.Map<ContactViewModel>(response);
            return result;
        }
        public bool DeleteContact(long id)
        {
            var result = _contactrepository.DeleteContact(id);
            return result;

        }

        public ContactViewModel UpadateContact(ContactViewModel contact)
        {
            var dbRow = _mapper.Map<Contact>(contact);
            var response = _contactrepository.UpdateContact(dbRow);
            var result = _mapper.Map<ContactViewModel>(response);
            return result;
        }

       

        
    }
}
