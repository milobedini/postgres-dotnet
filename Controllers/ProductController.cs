using Microsoft.AspNetCore.Mvc;

namespace postgres_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        // GET api/controller
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }



        // GET api/controller/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // Post api/controller
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/controller/5
        [HttpPut("{id")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // Delete api/controller/5
        [HttpDelete("{id")]
        public void Delete(int id)
        {

        }

    }
}