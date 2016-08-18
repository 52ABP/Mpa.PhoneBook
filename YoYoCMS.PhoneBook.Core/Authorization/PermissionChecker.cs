using Abp.Authorization;
using YoYoCMS.PhoneBook.Authorization.Roles;
using YoYoCMS.PhoneBook.MultiTenancy;
using YoYoCMS.PhoneBook.Users;

namespace YoYoCMS.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
