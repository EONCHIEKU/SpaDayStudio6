using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;
using SpaDay6.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [Route("/User/Add")]
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                    User newUser = new User
                    {
                        Username = addUserViewModel.Username,
                        Email = addUserViewModel.Email,
                        Password = addUserViewModel.Password
                        
                    };
                    return View("Index", newUser);
               
            }
             return View("Add", addUserViewModel);
           
        }
    }
}

