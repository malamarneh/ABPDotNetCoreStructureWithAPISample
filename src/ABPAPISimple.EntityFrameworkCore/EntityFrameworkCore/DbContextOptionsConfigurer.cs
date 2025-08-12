using Microsoft.EntityFrameworkCore;

namespace ABPAPISimple.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<ABPAPISimpleDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for ABPAPISimpleDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
