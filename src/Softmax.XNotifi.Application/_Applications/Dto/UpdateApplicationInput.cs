using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softmax.XNotifi._Applications.Dto
{
    [AutoMapTo(typeof(Application))]
    public class UpdateApplicationInput
    {
        public Guid ApplicationId { get; set; }

        public Guid ClientId { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
