using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YoYoCMS.PhoneBook.MultiTenancy.Dto;

namespace YoYoCMS.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
