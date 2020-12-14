using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InertiaTest.WebApp.Data.Models
{
    public class Account : Timestamp
    {
        [Column("account_id")]
        public string AccountId { get; set; }
        [Column("name")]
        [MaxLength(50)]
        public string Name { get; set; }
        
        public List<User> Users { get; set; }
        public List<Organization> Organizations { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}