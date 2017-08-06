using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RecipesApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        [HttpGet]
        public IActionResult Get()
        {            
            Byte[] b = System.IO.File.ReadAllBytes(@"C:\\Code\\Repos\\RecipesApi\\Pizza.jpg"); // You can use your own method over here.         
            return File(b, "image/jpeg");
        }
        // return image from web api
        // https://stackoverflow.com/questions/39177576/how-to-to-return-an-image-with-web-api-get-method

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
