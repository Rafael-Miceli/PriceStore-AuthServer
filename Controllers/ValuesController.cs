using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PriceStore_AuthServer.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        // POST api/values
        [HttpPost]
        public IActionResult  Post([FromBody]UserVm user)
        {
            if (user.Name == "Rafael" && user.Password == "123")
                return Ok(new User {
                    Name = "Rafael",
                    Email = "rafael.miceli@teste.com"
                });
            return Unauthorized();
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

    public class UserVm
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

