using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReduxOne.Models;

namespace ReduxOne.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private UserContext db;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(UserContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userManager.Users.ToList();
        }

        // GET api/users/5
        [HttpGet("{email}")]
        public IActionResult Get(string email)
        {
            User user = _userManager.Users.FirstOrDefault(x => x.Email == email);
            if (user == null)
                return NotFound();
            return new ObjectResult(user);
        }

        // POST api/users
        [HttpPost]
        public async void Post([FromBody]User user)
        {
            await _userManager.CreateAsync(user);
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

          
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            User user = db.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            db.Entry(user).State = EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    }
}