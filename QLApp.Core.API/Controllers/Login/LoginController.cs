using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLApp.Core.API.Base;
using QLApp.Core.BL.Base;
using QLApp.Core.BL.Login;
using QLApp.Core.Entities.Data;
using QLApp.Core.Entities.Dictionary;
using QLApp.Core.Entities.Dictionary.User;
using QLApp.Library.Collection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace QLApp.Core.API.Controllers.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : BaseController
    {
        public LoginController(AppCollection service) : base(service)
        {

        }
        
    }
}
