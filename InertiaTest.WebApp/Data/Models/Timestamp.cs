using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InertiaTest.WebApp.Data.Models
{
    public class Timestamp
    {
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}