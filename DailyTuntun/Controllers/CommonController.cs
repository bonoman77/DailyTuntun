﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyTuntun.Controllers
{
    public class CommonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
