﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace HRCoreModule.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : HRCoreModuleControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}