using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReduxOne.Models;

namespace ReduxOne
{
    public class UserContext:IdentityDbContext<User>
    {
        public UserContext(DbContextOptions<UserContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}