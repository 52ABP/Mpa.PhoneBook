using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using YoYoCMS.PhoneBook.Authorization;
using YoYoCMS.PhoneBook.MultiTenancy;

namespace YoYoCMS.PhoneBook.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenants)]
    public class TenantsController : PhoneBookControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}