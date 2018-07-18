using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Softmax.XNotifi.Configuration.Dto;

namespace Softmax.XNotifi.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : XNotifiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
