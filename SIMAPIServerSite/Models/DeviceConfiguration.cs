using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMAPIServerSite.Models
{
    public class DeviceConfiguration
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }
        public int Customer { get; set; }
        public string MonitoringServer1 { get; set; }
        public string MonitoringServer2 { get; set; }
        public string DialNumber1 { get; set; }
        public string DialNumber2 { get; set; }
        
        [Column("SMSNumber1")]
        public string SmsNumber1 { get; set; }
        
        [Column("SMSNumber2")]
        public string SmsNumber2 { get; set; }
        public string EthernetAddress { get; set; }
        public string GatewayAddress { get; set; }

        [Column("IsRequireStaticIP")]
        public bool IsRequireStaticIp { get; set; }
        public string Bureau { get; set; }
    }
}
