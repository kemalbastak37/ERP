﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YSKProje.ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")] //attribute ile diğer homecontrollerdan ayırıyoruz

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
