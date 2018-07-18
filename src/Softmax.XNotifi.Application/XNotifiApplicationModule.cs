using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Softmax.XNotifi.Authorization;

namespace Softmax.XNotifi
{
    [DependsOn(
        typeof(XNotifiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class XNotifiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<XNotifiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(XNotifiApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
