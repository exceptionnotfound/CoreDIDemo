using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreDIDemo.Interfaces;
using CoreDIDemo.ViewModels;

namespace CoreDIDemo.Controllers
{
    public class HomeController : Controller
    {
        private IInstanceUsersRepository _userRepo;
        public HomeController(IInstanceUsersRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public IActionResult Instance()
        {
            InstanceUsersVM model = new InstanceUsersVM();
            model.Users = _userRepo.GetAll();
            model.RandomNumber = _userRepo.GetCurrentRandomValue();
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
