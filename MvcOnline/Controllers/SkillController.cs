﻿using Microsoft.AspNetCore.Mvc;

namespace MvcOnline.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
