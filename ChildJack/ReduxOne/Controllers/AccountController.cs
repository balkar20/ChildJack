using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReduxOne.Models;

namespace ReduxOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<User> _roleManager;
        //private UserContext db;
        public AccountController(UserManager<User> userManager, RoleManager<User> roleManager)
        {
            _userManager = userManager;
            _roleManager= roleManager;

            if (!_userManager.Users.Any())
            {
                _userManager.AddToRoleAsync(new User {Email = "balkar20@mail.ru", UserName = "balkar20"}, "admin");
                _userManager.AddToRoleAsync(new User {Email = "kolobok@mail.ru", UserName = "kolobok"}, "user");
            }

        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userManager.Users.ToList();
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            User user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return NotFound();
            return new ObjectResult(user);
        }

        // POST api/users
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            await _userManager.AddToRoleAsync(user, "user");
            return Ok(user);
        }

        // PUT api/users/
        [HttpPut]
        public IActionResult Put([FromBody]User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            if (_userManager.Users.Any(x => x.Id == user.Id))
            {
                return NotFound();
            }

            _userManager.UpdateAsync(user);
            return Ok(user);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            User user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            _userManager.DeleteAsync(user);
            return Ok(user);
        }
    }
}