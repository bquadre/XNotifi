using System.Threading.Tasks;
using Abp.Application.Services;
using Softmax.XNotifi.Authorization.Accounts.Dto;

namespace Softmax.XNotifi.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
