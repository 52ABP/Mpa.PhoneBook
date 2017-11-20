using Abp.MultiTenancy;
using YoYoCMS.PhoneBook.Users;

namespace YoYoCMS.PhoneBook.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}