using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace InertiaTest.WebApp.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [Column("first_name")]
        [MaxLength(25)]
        public string FirstName { get; set; }
        
        [Required]
        [Column("last_name")]
        [MaxLength(25)]
        public string LastName { get; set; }
        
        [Column("photo_path")]
        [MaxLength(100)]
        public string PhotoPath { get; set; }
        
        [Column("deleted_at")]
        public DateTimeOffset? DeletedAt { get; set; }
        
        [Required]
        [Column("account_id")]
        public string AccountId { get; set; }
        public Account Account { get; set; }
    }
}