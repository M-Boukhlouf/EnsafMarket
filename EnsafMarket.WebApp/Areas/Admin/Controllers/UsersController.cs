﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

using EnsafMarket.WebApp.Areas.Admin.Controllers.Abstract;
using EnsafMarket.WebApp.Areas.Admin.ViewModels;

namespace EnsafMarket.WebApp.Areas.Admin.Controllers
{
    public class UsersController : BaseController
    {
        public async Task<ActionResult> Index()
        {
            var response = await emClient.GetUsersAsync();
            var users = response.Users;

            return View(new UsersViewModel
            {
                Users = users
            });
        }
    }
}