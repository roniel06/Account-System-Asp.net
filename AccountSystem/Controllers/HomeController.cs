﻿using AccountSystem.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Model;
using Service;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountSystem.Controllers
{
    [HandleError]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }
        public ActionResult Index()
        {
            //using(ApplicationDbContext db = new ApplicationDbContext())
            //{
            //    var role = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            //    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            //    userManager.AddToRole(User.Identity.GetUserId(), "Admin");
            //};

            ViewBag.Menbers = _homeService.GetAllMenbers();
            ViewBag.Debs = _homeService.GetAllDebs();
            ViewBag.Account = _homeService.GetAllAccounts();
            return View();
        }

        public ActionResult Client()
        {
            return View();
        }
    }
}