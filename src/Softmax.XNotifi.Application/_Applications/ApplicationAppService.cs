using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using Softmax.XNotifi._Applications.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softmax.XNotifi._Applications
{
    public class ApplicationAppService : XNotifiAppServiceBase, IApplicationAppService
    {
        private readonly IRepository<Application, Guid> _applicationRepository;

        public ApplicationAppService(IRepository<Application, Guid> applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task CreatApplication(CreateApplicationInput input)
        {
            var application = ObjectMapper.Map<Application>(input);
            var request = await _applicationRepository.InsertAsync(application);

            var result = request;
        }

        public async Task<ListResultDto<ListApplicationDto>> GetAll(GetAllApplicationsInput input)
        {
            var applications = await _applicationRepository
                .GetAll()
                // .WhereIf(input.State.HasValue, t => t.State == input.State.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<ListApplicationDto>(
                ObjectMapper.Map<List<ListApplicationDto>>(applications)
            );
        }

        public async Task UpdateApplication(UpdateApplicationInput input)
        {
            Logger.Info("Updating a task for input: " + input);

            var existingApplication = await _applicationRepository.FirstOrDefaultAsync(input.ApplicationId);
            if (existingApplication == null)
            {
                throw new UserFriendlyException(L("CouldNotFindTheTaskMessage"));
            }

            var updatingApplication = ObjectMapper.Map<Application>(input);
            await _applicationRepository.UpdateAsync(updatingApplication);
        }
    }
}
