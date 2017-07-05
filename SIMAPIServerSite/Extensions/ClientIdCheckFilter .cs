using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace SIMAPIServerSite.Extensions
{
    //if logic is complex, we could use filter to do this
    public class ClientIdCheckFilter : ActionFilterAttribute
    {
        private readonly ILogger _logger;

        public ClientIdCheckFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("ClassConsoleLogActionOneFilter");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation($"Remote IpAddress: {context.HttpContext.Connection.RemoteIpAddress}");

            //context.HttpContext.Connection.RemoteIpAddress

            // TODO implement some business logic for this...

            base.OnActionExecuting(context);
        }
    }
}
