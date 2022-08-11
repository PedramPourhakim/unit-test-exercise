using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult A1(string test)
        {
            return Ok("Done !");
        }     
        [HttpPost]
        public IActionResult A2([FromBody]Models.Person person)
        {
            return Ok("Done !");
        }
        
        public bool A3()
        {
            return true;
        }

    }
}
