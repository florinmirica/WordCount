﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ViewResult Index() { return View(); }
        
        
    }
}
