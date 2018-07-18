using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Softmax.XNotifi.Roles.Dto;
using Softmax.XNotifi.Users.Dto;

namespace Softmax.XNotifi.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
