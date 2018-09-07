using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReduxOne.Models;

namespace ReduxOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserContext userContext;

        public UserController(UserContext userContext)
        {
            this.userContext = userContext;

        }

        [HttpGet("[action]")]
        public IEnumerable<User> GetUsers()
        {
            var uss = userContext.Users.ToList();
            return uss;
        }

        [HttpGet("[action]")]
        public User GetUser(string email)
        {
            var user = userContext.Users.Where(u => u.Email == email).FirstOrDefault();
            return user;
        }
    }
}