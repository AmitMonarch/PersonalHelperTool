﻿using Microsoft.AspNetCore.Mvc;

namespace CodeFlowDocumentation.API.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
