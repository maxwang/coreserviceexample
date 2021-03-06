﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMAPIServerSite.Models
{
    [Table("DeviceSimAllocation")]
    public class DeviceSimAllocation
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }

        public int DeviceAllocation { get; set; }
        public int Provider { get; set; }
        public string SimNumber { get; set; }
        public bool IsSelected { get; set; }
    }
}
