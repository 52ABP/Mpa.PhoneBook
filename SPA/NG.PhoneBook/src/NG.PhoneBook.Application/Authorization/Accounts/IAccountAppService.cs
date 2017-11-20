using System.Threading.Tasks;
using Abp.Application.Services;
using NG.PhoneBook.Authorization.Accounts.Dto;

namespace NG.PhoneBook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
