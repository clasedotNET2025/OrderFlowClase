using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OrderFlowClase.API.Identity.Data
{
    public class MyAppContextFactory : IDesignTimeDbContextFactory<MyAppContext>
    {
        public MyAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyAppContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Database=identitydb;Username=postgres;Password=postgres");

            return new MyAppContext(optionsBuilder.Options);
        }
    }
}
