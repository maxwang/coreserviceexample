﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMAPIServerSite.Models
{
    [Table("FeatureValueType")]
    public class FeatureValueType
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Key { get; set; }
    }
}
