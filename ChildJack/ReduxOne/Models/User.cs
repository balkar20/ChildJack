using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ReduxOne.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            
        }
        public int Year { get; set; }
    }
}