using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Contacts.Models
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        
    }
}