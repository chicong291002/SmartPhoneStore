﻿using Microsoft.AspNetCore.Mvc;
using ShoeStore.Application.System.Users.DTOS;

namespace ShoeStore.AdminApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginRequest request)
        {
            return View();
        }
    }
}
