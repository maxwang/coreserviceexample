using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIMAPIServerSite.Models;

namespace SIMAPIServerSite.Repository
{
    public interface ISimConfigurationRepository
    {
        Task<DtuConfiguration> GetDtuConfigurationAsync(string simNumber);
    }
}
