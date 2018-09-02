using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChildJack.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChildJack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private List<User> users;

        public UserController()
        {
            this.users = new List<User>
            {
                new User{Id = 1, Name = "Vlad", Email = "balkar20@mail.ru"},
                new User{Id = 2, Name = "Slava", Email = "kolobok@mail.ru"},
                new User{Id = 3, Name = "Kombo", Email = "kombo@mail.ru"},
                new User{Id = 4, Name = "Jes", Email = "jessey0@mail.ru"},
                new User{Id = 5, Name = "Marla", Email = "Marla@mail.ru"}
            };
        }

        [HttpGet("[action]")]
        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public User GetUser(int id)
        {
            return users.Where(u =>u.Id == id).FirstOrDefault();
        }
    }
}