using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPAPISimple.Localization;

namespace ABPAPISimple
{
    public class ABPAPISimpleCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            ABPAPISimpleLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = ABPAPISimpleConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAPISimpleCoreModule).GetAssembly());
        }
    }
}