﻿using RNTAProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RNTAProject.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AddOrEdit(int id=0)
        {
            User userModel = new User();
            return View(userModel);
        }
    }
}