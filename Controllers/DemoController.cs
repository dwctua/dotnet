using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// using demo.Models;
using System.Net.Http;

namespace demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly string url = "https://function1005.azurewebsites.net/api/HttpTrigger1?code=DKZuGg2kyuv0pb9Iv4OXdTM3Yp9GzzLvpQkv8QckszL7OW3sa1iZ3A==";

        public DemoController()
        {}

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var text = await response.Content.ReadAsStringAsync();

            return new OkObjectResult(text);
            // return new OkObjectResult("hello");
        }

    }
}