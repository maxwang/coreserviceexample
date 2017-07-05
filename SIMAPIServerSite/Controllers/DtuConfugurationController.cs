using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SIMAPIServerSite.Models;
using SIMAPIServerSite.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SIMAPIServerSite.Controllers
{
    

    [Route("api/sim")]
    public class DtuConfugurationController : Controller
    {
        private readonly ISimConfigurationRepository _simConfiguration;

        public DtuConfugurationController(ISimConfigurationRepository simConfiguration)
        {
            _simConfiguration = simConfiguration;
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<JsonResult> Get([FromRoute]string id)
        {
            var result =  await _simConfiguration.GetDtuConfigurationAsync(id);

            return result == null
                ? Json(new
                {
                })
                : Json(new
                {
                    SIM1 = result.Sim1,
                    SIM2 = result.Sim2,
                    Base = result.Base,
                    Account = result.Account,
                    Mode = result.Mode,
                    Poll = result.Poll,
                    IP1 = result.Ip1,
                    IP2 = result.Ip2,
                    Dial1 = result.Dial1,
                    Dial2 = result.Dial2,
                    Sms1 = result.Sms1,
                    Sms2 = result.Sms2,
                    Ethernet = result.Ethernet,
                    Gateway = result.Gateway,
                    Internet1 = result.Internet1,
                    Internet2 = result.Internet2
                });
        }
        
    }
}
