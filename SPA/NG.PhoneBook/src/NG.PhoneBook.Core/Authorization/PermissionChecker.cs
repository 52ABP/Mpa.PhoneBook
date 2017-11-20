using Abp.Authorization;
using NG.PhoneBook.Authorization.Roles;
using NG.PhoneBook.Authorization.Users;

namespace NG.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
