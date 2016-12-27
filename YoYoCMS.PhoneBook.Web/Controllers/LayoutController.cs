using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Runtime.Session;
using Abp.Threading;
using YoYoCMS.PhoneBook.Sessions;
using YoYoCMS.PhoneBook.Web.Models.Layout;

namespace YoYoCMS.PhoneBook.Web.Controllers
{
    public class LayoutController : PhoneBookControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly ILocalizationManager _localizationManager;
        private readonly ILanguageManager _languageManager;
        private readonly ISessionAppService _sessionAppService;
        private readonly IMultiTenancyConfig _multiTenancyConfig;

        public LayoutController(
            IUserNavigationManager userNavigationManager, 
            ILocalizationManager localizationManager,
            ISessionAppService sessionAppService, 
            IMultiTenancyConfig multiTenancyConfig, ILanguageManager languageManager)
        {
            _userNavigationManager = userNavigationManager;
            _localizationManager = localizationManager;
            _sessionAppService = sessionAppService;
            _multiTenancyConfig = multiTenancyConfig;
            _languageManager = languageManager;
        }

        [ChildActionOnly]
        public PartialViewResult TopMenu(string activeMenu = "")
        {
            var model = new TopMenuViewModel
                        {
                            MainMenu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("MainMenu", AbpSession.ToUserIdentifier())),
                            ActiveMenuItemName = activeMenu
                        };

            return PartialView("_TopMenu", model);
        }

        [ChildActionOnly]
        public PartialViewResult LanguageSelection()
        {
            var model = new LanguageSelectionViewModel
                        {
                            CurrentLanguage = _languageManager.CurrentLanguage,
                            Languages = _languageManager.GetLanguages()
                        };

            return PartialView("_LanguageSelection", model);
        }


        [ChildActionOnly]
        public PartialViewResult UserMenuOrLoginLink()
        {
            UserMenuOrLoginLinkViewModel model;

            if (AbpSession.UserId.HasValue)
            {
                model = new UserMenuOrLoginLinkViewModel
                {
                    LoginInformations = AsyncHelper.RunSync(() => _sessionAppService.GetCurrentLoginInformations()),
                    IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled,
                };
            }
            else
            {
                model = new UserMenuOrLoginLinkViewModel
                {
                    IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled                    
                };
            }

            return PartialView("_UserMenuOrLoginLink", model);
        }
    }
}