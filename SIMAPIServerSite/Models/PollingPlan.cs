using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMAPIServerSite.Models
{
    public class PollingPlan
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Identifier { get; set; }
        public int Frequency { get; set; }
        public int FrequencyInterval { get; set; }
        public int NoOfSelectedSims { get; set; }
    }
}
