﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HB.Presentation.Controllers
{
	public class HistoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
