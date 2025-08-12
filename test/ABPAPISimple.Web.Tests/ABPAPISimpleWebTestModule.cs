using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPAPISimple.Web.Startup;
namespace ABPAPISimple.Web.Tests
{
    [DependsOn(
        typeof(ABPAPISimpleWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class ABPAPISimpleWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAPISimpleWebTestModule).GetAssembly());
        }
    }
}