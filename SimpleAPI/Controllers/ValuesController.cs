using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "benvenuto", "da","Casimiro", "Greco" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Casimiro Greco";
        }
    }
}
