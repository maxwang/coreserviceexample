using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMAPIServerSite.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string AccountNumber { get; set; }

        [Column("CMSSettings")]
        public int CmsSettings { get; set; }

    }
}
