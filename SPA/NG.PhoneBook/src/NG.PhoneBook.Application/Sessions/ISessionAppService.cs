using System.Threading.Tasks;
using Abp.Application.Services;
using NG.PhoneBook.Sessions.Dto;

namespace NG.PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
