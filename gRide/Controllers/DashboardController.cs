﻿using Microsoft.AspNetCore.Mvc;

namespace gRide.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}