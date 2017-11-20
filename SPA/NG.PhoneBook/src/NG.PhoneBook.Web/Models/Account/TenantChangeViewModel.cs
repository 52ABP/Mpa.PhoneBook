using Abp.AutoMapper;
using NG.PhoneBook.Sessions.Dto;

namespace NG.PhoneBook.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}