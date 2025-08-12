using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ABPAPISimple
{
    [DependsOn(
        typeof(ABPAPISimpleCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPAPISimpleApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAPISimpleApplicationModule).GetAssembly());
        }
    }
}