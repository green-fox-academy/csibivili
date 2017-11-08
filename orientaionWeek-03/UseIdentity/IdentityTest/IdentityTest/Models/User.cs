using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityTest.Models
{
    public class MyUser : IdentityUser<int>
    {
        int UserId { get; set; }
    }
}
