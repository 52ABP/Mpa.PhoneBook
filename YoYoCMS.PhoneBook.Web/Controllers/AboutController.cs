using System.Web.Mvc;

namespace YoYoCMS.PhoneBook.Web.Controllers
{
    public class AboutController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}