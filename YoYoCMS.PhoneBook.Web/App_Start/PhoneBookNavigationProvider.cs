using Abp.Application.Navigation;
using Abp.Localization;
using YoYoCMS.PhoneBook.Authorization;
using YoYoCMS.PhoneBook.Persons.Authorization;

namespace YoYoCMS.PhoneBook.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See Views/Layout/_TopMenu.cshtml file to know how to render menu.
    /// </summary>
    public class PhoneBookNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {

            var person = new MenuItemDefinition(
              PersonAppPermissions.Person,
              L("Person"),
              url: "PersonManage",
              icon: "fa fa-user-md",
              requiredPermissionName:PersonAppPermissions.Person
              );

            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        L("HomePage"),
                        url: "",
                        icon: "fa fa-home",
                        requiresAuthentication: true
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Tenants",
                        L("Tenants"),
                        url: "Tenants",
                        icon: "fa fa-globe",
                        requiredPermissionName: AppPermissions.Pages_Tenants
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Users",
                        L("Users"),
                        url: "Users",
                        icon: "fa fa-users",
                        requiredPermissionName: AppPermissions.Pages_Users
                        )
                ).AddItem(person).AddItem(
                    new MenuItemDefinition(
                        "About",
                        L("About"),
                        url: "About",
                        icon: "fa fa-info"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, PhoneBookConsts.LocalizationSourceName);
        }
    }
}
