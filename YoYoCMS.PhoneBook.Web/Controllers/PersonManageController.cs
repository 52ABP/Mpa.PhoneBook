using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using YoYoCMS.PhoneBook.Persons;
using YoYoCMS.PhoneBook.Persons.Authorization;
using YoYoCMS.PhoneBook.Persons.Dtos;

namespace YoYoCMS.PhoneBook.Web.Controllers
{
    [AbpMvcAuthorize(PersonAppPermissions.Person)]
    public class PersonManageController : PhoneBookControllerBase
    {

        private readonly IPersonAppService _personAppService;

        public PersonManageController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        // GET: PersonManage
        public async System.Threading.Tasks.Task<ActionResult> Index(GetPersonInput input)
        {

            var output = await _personAppService.GetPagedPersonsAsync(input);

            return View(output);
        }
    }
}