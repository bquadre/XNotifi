using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softmax.XNotifi._Applications.Dto
{
    [AutoMapTo(typeof(Application))]
    public class GetAllApplicationsInput
    {
    }
}
