using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMAPIServerSite.Models
{
    public class Request
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }
        public int DeviceAllocation { get; set; }
        public int RequestType { get; set; }
        public int PollingPlan { get; set; }
        public DateTime DateCreated { get; set; }
        public string Creator { get; set; }
        public bool IsFileCreated { get; set; }
        public bool IsEmailed { get; set; }
        public int Status { get; set; }
    }
}
