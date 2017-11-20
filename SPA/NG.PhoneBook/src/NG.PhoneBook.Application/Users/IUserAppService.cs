using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NG.PhoneBook.Roles.Dto;
using NG.PhoneBook.Users.Dto;

namespace NG.PhoneBook.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}