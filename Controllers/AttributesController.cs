﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySystem.Controllers
{
    public class AttributesController : Controller
    {
        // GET: Attributes
        public ActionResult Index()
        {
            
            return View("AttView");
        }
    }
}