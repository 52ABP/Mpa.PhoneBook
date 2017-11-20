using Abp.Authorization;
using Abp.Localization;
using NG.PhoneBook.Authorization;

namespace NG.PhoneBook.Persons.Authorization
{
	/// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="PersonAppPermissions"/> for all permission names.
    /// </summary>
    public class PersonAppAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context){
					      //在这里配置了Person 的权限。

            var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));
            var person = pages.CreateChildPermission(PersonAppPermissions.Person , L("Person"));
            person.CreateChildPermission(PersonAppPermissions.Person_CreatePerson, L("CreatePerson"));
            person.CreateChildPermission(PersonAppPermissions.Person_UpdatePerson, L("UpdatePerson"));           
            person.CreateChildPermission(PersonAppPermissions. Person_DeletePerson, L("DeletePerson"));
 
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, PhoneBookConsts.LocalizationSourceName);
        }
    }




}