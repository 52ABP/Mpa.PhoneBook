using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NG.PhoneBook.MultiTenancy.Dto;

namespace NG.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
