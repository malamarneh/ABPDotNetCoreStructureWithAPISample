using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPAPISimple.Configuration;
using ABPAPISimple.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace ABPAPISimple.Web.Startup
{
    [DependsOn(
        typeof(ABPAPISimpleApplicationModule), 
        typeof(ABPAPISimpleEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class ABPAPISimpleWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ABPAPISimpleWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(ABPAPISimpleConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<ABPAPISimpleNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(ABPAPISimpleApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAPISimpleWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ABPAPISimpleWebModule).Assembly);
        }
    }
}
