using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OrderFlowClase.API.Identity.Data
{
    public class MyAppContext : IdentityDbContext<IdentityUser>
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        {
        }
    }
}
