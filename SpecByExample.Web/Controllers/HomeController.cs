﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SpecByExample.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}
	}
}