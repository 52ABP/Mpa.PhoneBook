using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using YoYoCMS.PhoneBook.Authorization;
using YoYoCMS.PhoneBook.Users;

namespace YoYoCMS.PhoneBook.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Users)]
    public class UsersController : Controller
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}