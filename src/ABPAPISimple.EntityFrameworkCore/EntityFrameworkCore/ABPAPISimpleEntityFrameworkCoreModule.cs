using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ABPAPISimple.EntityFrameworkCore
{
    [DependsOn(
        typeof(ABPAPISimpleCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class ABPAPISimpleEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAPISimpleEntityFrameworkCoreModule).GetAssembly());
        }
    }
}