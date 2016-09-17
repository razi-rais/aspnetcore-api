using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myapi.Controllers
{
    [Route("api/[controller]")]
    public class MachineInfoController : Controller
   {
 

	// GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {  
					  Environment.MachineName,
					  System.Runtime.InteropServices.RuntimeInformation.OSDescription
				};
        }
	
   }

}
