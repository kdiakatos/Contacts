//using DataAccessLayer.Entities;
using Contacts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
           : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        
    }



}
