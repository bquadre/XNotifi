using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Softmax.XNotifi.MultiTenancy.Dto;

namespace Softmax.XNotifi.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
