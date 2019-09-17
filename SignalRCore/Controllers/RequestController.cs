using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalRCore.Models;

namespace SignalRCore.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class RequestController : ControllerBase
    {
        ApplicationContext db;
        private readonly UserManager<IdentityUser> _userManager;

        public RequestController(ApplicationContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            db = context;

        }
    }
}