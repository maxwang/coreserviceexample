using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SIMAPIServerSite.Data;
using SIMAPIServerSite.Models;

namespace SIMAPIServerSite.Repository
{
    public class SimConfigurationDbRepository : ISimConfigurationRepository
    {
        private readonly ApplicationDbContext _db;
        //public IEnumerable<DtuConfiguration> DtuConfigurations => _db.DtuConfigurations.AsNoTracking();
        public async Task<DtuConfiguration> GetDtuConfigurationAsync(string simNumber)
        {
            //var result = new DtuConfiguration();

            var result = await (from dss in _db.DeviceSimAllocations
                join ds in _db.DeviceAllocations on dss.DeviceAllocation equals ds.Id
                join dc in _db.DeviceConfigurations on ds.DeviceConfiguration equals dc.Id
                join c in _db.Customers on dc.Customer equals  c.Id
                join cs in _db.CmsSettings on c.CmsSettings equals cs.Id
                join r in _db.Requests on ds.Id equals  r.DeviceAllocation
                join p in _db.PollingPlan on r.PollingPlan equals p.Id
                where dss.SimNumber.Equals(simNumber)
                orderby dss.Id descending 
                select new DtuConfiguration
                {
                    Sim1 = simNumber,
                    Account = c.AccountNumber,
                    Base = cs.BaseNumber,
                    DeviceAllocation = dss.DeviceAllocation,
                    Dial1 = cs.DialNumber1,
                    Dial2 = cs.DialNumber2,
                    Ethernet = cs.EthernetAddress,
                    Gateway = cs.GatewayAddress,
                    Ip1 = cs.Defaultip1,
                    Ip2 = cs.Defaultip2,
                    Internet1 = cs.InternetAddress1,
                    Internet2 = cs.InternetAddress2,
                    Poll = p.Frequency,
                    Request = r.Id,
                    Sms1 = cs.SmsNumber1,
                    Sms2 = cs.SmsNumber2                    
                }).FirstOrDefaultAsync();

            if (result == null)
            {
                return null;
            }

            var modeList = from rf in _db.RequestFeatures
                join r in _db.Features on rf.Feature equals r.Id
                join f in _db.FeatureValueTypes on r.ValueAppliesTo equals f.Id
                where rf.Request == result.Request && f.Key.Equals("DM")
                select  r.Value;

            int value = 0;
            int modeValue = 0;
            foreach (var mode in modeList)
            {
                if (int.TryParse(mode, out value))
                {
                    modeValue += value;
                }
            }

            result.Mode = modeValue;

            //find sim2
            var sim2 = await (from d in _db.DeviceSimAllocations
                where d.DeviceAllocation == result.DeviceAllocation && !d.SimNumber.Equals(result.Sim1)
                select d.SimNumber
            ).FirstOrDefaultAsync();

            if (sim2 != null)
            {
                result.Sim2 = sim2;
            }
            else
            {
                result.Sim2 = string.Empty;
            }
            
            return result;
            
        }

        public SimConfigurationDbRepository(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
    }
}
