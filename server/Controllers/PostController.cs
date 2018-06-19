using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace social_feed_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        // GET api/posts
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "post1", "post2" };
        }

        // GET api/posts/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "post";
        }

        // POST api/posts
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/posts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/posts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
