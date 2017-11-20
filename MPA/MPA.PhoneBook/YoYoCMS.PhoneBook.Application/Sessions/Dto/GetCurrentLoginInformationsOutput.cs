using Abp.Application.Services.Dto;

namespace YoYoCMS.PhoneBook.Sessions.Dto
{
    public class GetCurrentLoginInformationsOutput 
    {
        public UserLoginInfoDto User { get; set; }

        public TenantLoginInfoDto Tenant { get; set; }
    }
}