using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMAPIServerSite.Models
{
    
    public class DtuConfiguration
    {
        public string Sim1 { get; set; }
        public string Sim2 { get; set; }
        public string Base { get; set; }
        public string Account { get; set; }
        public int Mode { get; set; }
        public int Poll { get; set; }
        public string Ip1 { get; set; }
        public string Ip2 { get; set; }
        public string Dial1 { get; set; }
        public string Dial2 { get; set; }
        public string Sms1 { get; set; }
        public string Sms2 { get; set; }
        public string Ethernet { get; set; }
        public string Gateway { get; set; }
        public string Internet1 { get; set; }
        public string Internet2 { get; set; }
        
        public int Request { get; set; }
        public int DeviceAllocation { get; set; }
    }
}
