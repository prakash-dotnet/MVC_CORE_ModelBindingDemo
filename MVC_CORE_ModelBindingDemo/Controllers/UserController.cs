using Microsoft.AspNetCore.Mvc;
using MVC_CORE_ModelBindingDemo.Models;

namespace MVC_CORE_ModelBindingDemo.Controllers
{
    public class UserController : Controller
    {
 
        [HttpGet]
        public IActionResult Register()
        {
            // Display the form
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserModel user)
        {
            if (ModelState.IsValid)
            {
                //display User Name, Email and Age on the web page
                return Content($"Name: {user.Name}, Email: {user.Email}, Age: {user.Age}");
            }

            return View(user);
        }

    }
}
