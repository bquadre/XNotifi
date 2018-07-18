using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Softmax.XNotifi._Applications.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softmax.XNotifi._Applications
{
    public interface IApplicationAppService : IApplicationService
    {
        Task<ListResultDto<ListApplicationDto>> GetAll(GetAllApplicationsInput input);

        Task CreatApplication(CreateApplicationInput input);

        Task UpdateApplication(UpdateApplicationInput input);
    }
}
