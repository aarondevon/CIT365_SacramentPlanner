﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CIT365_SacramentPlanner.Controllers
{
    public class MeetingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}