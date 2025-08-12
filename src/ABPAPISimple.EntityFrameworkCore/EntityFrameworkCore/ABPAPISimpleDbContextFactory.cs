using ABPAPISimple.Configuration;
using ABPAPISimple.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ABPAPISimple.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class ABPAPISimpleDbContextFactory : IDesignTimeDbContextFactory<ABPAPISimpleDbContext>
    {
        public ABPAPISimpleDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPAPISimpleDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(ABPAPISimpleConsts.ConnectionStringName)
            );

            return new ABPAPISimpleDbContext(builder.Options);
        }
    }
}