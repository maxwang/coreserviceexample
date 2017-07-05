using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace SIMAPIServerSite.Services
{
    public class AdminWhiteListMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AdminWhiteListMiddleware> _logger;
        //private readonly string _adminWhiteList;
        private string[] _ip;
        public AdminWhiteListMiddleware(RequestDelegate next, ILogger<AdminWhiteListMiddleware> logger, string adminWhiteList)
        {
            _ip = adminWhiteList.Split(';');
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method.Equals("GET", StringComparison.CurrentCultureIgnoreCase))
            {
                var remoteIp = context.Connection.RemoteIpAddress;
                _logger.LogInformation($"Request from Remote IP address: {remoteIp}");
               
                if (!_ip.Any(option => option == remoteIp.ToString()))
                {
                    _logger.LogInformation($"Forbidden Request from Remote IP address: {remoteIp}");
                    context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                    return;
                }
            }

            await _next.Invoke(context);

        }


    }
}
