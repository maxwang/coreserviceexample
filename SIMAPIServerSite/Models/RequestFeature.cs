using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMAPIServerSite.Models
{
    public class RequestFeature
    {
        [Column("ID")]
        [Key]
        public string Id { get; set; }

        public int Request { get; set; }
        public int Feature { get; set; }
    }
}
