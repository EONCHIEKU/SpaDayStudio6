using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/User/Add")]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("/User")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
            ViewBag.Username = newUser.Username;
            ViewBag.Email = newUser.Email;
            ViewBag.Date = newUser.Date;


                if(newUser.Password == verify)
            {
                ViewBag.Username = newUser.Username;
                return View("Index");
            }
            else
            {
                ViewBag.Error = "Put in the correct password.";
                return View("Add");
            }

        }
    }
}
