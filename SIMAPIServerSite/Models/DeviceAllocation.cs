using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMAPIServerSite.Models
{
    [Table("DeviceAllocation")]
    public class DeviceAllocation
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }
        public int BaseStation { get; set; }
        public string BatchIdentifier { get; set; }
        public string DeviceSerialNumber { get; set; }
        public int SimActivationSalesKit { get; set; }
        public int DeviceConfiguration { get; set; }
        public int RequestType { get; set; }
    }
}
