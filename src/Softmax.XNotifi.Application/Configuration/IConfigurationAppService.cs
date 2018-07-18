using System.Threading.Tasks;
using Softmax.XNotifi.Configuration.Dto;

namespace Softmax.XNotifi.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
