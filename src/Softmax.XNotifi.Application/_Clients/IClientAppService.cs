using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Softmax.XNotifi._Clients.Dto;
using System.Threading.Tasks;

namespace Softmax.XNotifi._Clients
{
    public interface IClientAppService : IApplicationService
    {
        Task<ListResultDto<ListClientDto>> GetAll(GetAllClientsInput input);

        Task Create(CreateClientInput input);

        Task Update(UpdateClientInput input);
    }
}
