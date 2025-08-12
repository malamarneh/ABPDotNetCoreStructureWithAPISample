using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ABPAPISimple.EntityFrameworkCore
{
    public class ABPAPISimpleDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public ABPAPISimpleDbContext(DbContextOptions<ABPAPISimpleDbContext> options) 
            : base(options)
        {

        }
    }
}
