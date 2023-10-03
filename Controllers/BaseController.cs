using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidHealthDeclarationForm.Controllers
{
    public class BaseController : Controller
    {
        private readonly IConfiguration _configuration;

        public BaseController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            IsAuthorizedDevice();

            base.OnActionExecuting(filterContext);
        }

        public void IsAuthorizedDevice()
        {
            string[] authorizedDevices = _configuration.GetSection("AuthorizedDevices").Get<string[]>();

            if (authorizedDevices != null && authorizedDevices.Contains(System.Net.Dns.GetHostName()))
            {
                ViewBag.IsAuthorized = true;
            }
            else
            {
                ViewBag.IsAuthorized = false;
            }

        }
    }
}
