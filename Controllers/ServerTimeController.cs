using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myapi.Controllers
{
    [Route("api/[controller]")]
    public class ServerTimeController : Controller
    {
        // GET api/values
        [HttpGet]
        public  string Get()
        {
            return DateTime.Now.ToString();
        }
    }
}
