using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InertiaTest.WebApp.Data.Models
{
    public class Organization : Timestamp
    {
        [Column("organization_id")]
        public string OrganizationId { get; set; }
        [Required]
        [Column("name")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Column("email")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Column("phone")]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Column("address")]
        [MaxLength(150)]
        public string Address { get; set; }
        [Column("City")]
        [MaxLength(50)]
        public string City { get; set; }
        [Column("region")]
        [MaxLength(50)]
        public string Region { get; set; }
        [Column("country")]
        [MaxLength(2)]
        public string Country { get; set; }
        [Column("postal_code")]
        [MaxLength(50)]
        public string PostalCode { get; set; }
        
        [Column("deleted_at")]
        public DateTimeOffset? DeletedAt { get; set; }
        
        [Required]
        [Column("account_id")]
        public string AccountId { get; set; }
        public Account Account { get; set; }
        
        public List<Contact> Contacts { get; set; }
    }
}