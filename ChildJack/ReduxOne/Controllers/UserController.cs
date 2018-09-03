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
        private List<User> users;
        private UserContext userContext;

        public UserController(UserContext userContext)
        {
            this.userContext = userContext;

        }

        [HttpGet("[action]")]
        public IEnumerable<User> GetUsers(int id)
        {
            var users = new List<User> {
            new User { Name = "Kombo", Email = "kombo@mail.ru", Password = "12345"},
            new User {Name = "Jes", Email = "jessey0@mail.ru", Password = "12345"},
            new User { Name = "Marla", Email = "Marla@mail.ru", Password = "12345"}
            };
            try
            {
                var userTodel = this.userContext.Users.Where(u => u.Id == 1).FirstOrDefault();
                userContext.Users.Remove(userTodel);
                this.userContext.SaveChanges();
            }
            catch (Exception e)
            {
                var mes = e.Message;
            }
            var uss = userContext.Users.ToList();
            return uss;

        }

        public User GetUser(int id)
        {
            return users.Where(u => u.Id == id).FirstOrDefault();
        }
    }
}