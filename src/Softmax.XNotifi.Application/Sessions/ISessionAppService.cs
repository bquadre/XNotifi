using System.Threading.Tasks;
using Abp.Application.Services;
using Softmax.XNotifi.Sessions.Dto;

namespace Softmax.XNotifi.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
