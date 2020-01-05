using AutoMapper;
using BusinessLayer.Models;
using Contacts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Contact, ContactViewModel>();
            CreateMap<ContactViewModel, Contact>();

            


        }
    }
}
