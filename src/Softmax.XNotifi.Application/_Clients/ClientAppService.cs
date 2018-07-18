using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using Softmax.XNotifi._Clients.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softmax.XNotifi._Clients
{
    public class ClientAppService : XNotifiAppServiceBase, IClientAppService
    {
        private readonly IRepository<Client, Guid> _clientRepository;

        public ClientAppService(IRepository<Client, Guid> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task Create(CreateClientInput input)
        {
            var client = ObjectMapper.Map<Client>(input);
            var request = await _clientRepository.InsertAsync(client);

            var result = request;
        }

        public async Task<ListResultDto<ListClientDto>> GetAll(GetAllClientsInput input)
        {
            var clients = await _clientRepository
                .GetAll()
               // .WhereIf(input.State.HasValue, t => t.State == input.State.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<ListClientDto>(
                ObjectMapper.Map<List<ListClientDto>>(clients)
            );
        }

        public async Task Update(UpdateClientInput input)
        {
            Logger.Info("Updating a task for input: " + input);

            var existingClient = await _clientRepository.FirstOrDefaultAsync(input.ClientId);
            if (existingClient == null)
            {
                throw new UserFriendlyException(L("CouldNotFindTheTaskMessage"));
            }

            var updatingClient = ObjectMapper.Map<Client>(input);
            await _clientRepository.UpdateAsync(updatingClient);
        }
    }
}
