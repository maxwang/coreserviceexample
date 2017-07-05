using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIMAPIServerSite.Models;

namespace SIMAPIServerSite.Repository
{
    public class SimConfigurationMemoryRepository : ISimConfigurationRepository
    {
        //public IEnumerable<DtuConfiguration> DtuConfigurations =>
        //    new List<DtuConfiguration>
        //    {
        //        new DtuConfiguration
        //        {
        //            Sim1 = "1234567890",
        //            Sim2 = "9876543120",
        //            Base = 3,
        //            Account =500,
        //            Dial1 = "1234455",
        //            Dial2 = string.Empty,
        //            Ethernet = string.Empty,
        //            Gateway = string.Empty,
        //            Internet1 = "10.220.30.252",
        //            Internet2 = "10.220.30.253"
        //        },
        //        new DtuConfiguration
        //        {
        //            Sim1 = "1234567790",
        //            Sim2 = "9876548890",
        //            Base = 3,
        //            Account =500,
        //            Dial1 = "1234455",
        //            Dial2 = string.Empty,
        //            Ethernet = string.Empty,
        //            Gateway = string.Empty,
        //            Internet1 = "10.220.30.252",
        //            Internet2 = "10.220.30.253"
        //        }
        //    };

        public async Task<DtuConfiguration> GetDtuConfigurationAsync(string simNumber)
        {
            return await Task.FromResult(new DtuConfiguration
            {
                Sim1 = "1234567790",
                Sim2 = "9876548890",
                Base = "3",
                Account = "500",
                Dial1 = "1234455",
                Dial2 = string.Empty,
                Ethernet = string.Empty,
                Gateway = string.Empty,
                Internet1 = "10.220.30.252",
                Internet2 = "10.220.30.253"
            });
        }
    }
}
