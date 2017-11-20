using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace YoYoCMS.PhoneBook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}