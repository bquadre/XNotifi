using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softmax.XNotifi._Applications.Dto
{
    [AutoMapTo(typeof(Application))]
    public class ListApplicationDto : EntityDto<Guid>, IHasCreationTime
    {
        public DateTime CreationTime { get; set; }
    }
}
