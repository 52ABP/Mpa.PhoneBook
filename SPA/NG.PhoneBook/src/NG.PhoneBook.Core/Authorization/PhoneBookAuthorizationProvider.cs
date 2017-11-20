using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace NG.PhoneBook.Authorization
{
    public class PhoneBookAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(AppPermissions.Pages_Users, L("Users"));
            context.CreatePermission(AppPermissions.Pages_Roles, L("Roles"));
            context.CreatePermission(AppPermissions.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, PhoneBookConsts.LocalizationSourceName);
        }
    }
}
