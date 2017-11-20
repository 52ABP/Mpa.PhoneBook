using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using YoYoCMS.PhoneBook.Authorization.Roles;

namespace YoYoCMS.PhoneBook.Users
{
    public class UserStore : AbpUserStore<Role, User>
    {
        public UserStore(
       IRepository<User, long> userRepository,
       IRepository<UserLogin, long> userLoginRepository,
       IRepository<UserRole, long> userRoleRepository,
       IRepository<Role> roleRepository,
       IRepository<UserPermissionSetting, long> userPermissionSettingRepository,
       IUnitOfWorkManager unitOfWorkManager,
       IRepository<UserClaim, long> userClaimStore)
       : base(
         userRepository,
         userLoginRepository,
         userRoleRepository,
         roleRepository,
         userPermissionSettingRepository,
         unitOfWorkManager,
         userClaimStore)
        {
        }
    }
}