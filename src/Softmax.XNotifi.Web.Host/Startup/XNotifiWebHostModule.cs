using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Softmax.XNotifi.Configuration;

namespace Softmax.XNotifi.Web.Host.Startup
{
    [DependsOn(
       typeof(XNotifiWebCoreModule))]
    public class XNotifiWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public XNotifiWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XNotifiWebHostModule).GetAssembly());
        }
    }
}
