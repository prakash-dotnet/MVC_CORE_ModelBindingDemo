using Microsoft.AspNetCore.Mvc;

namespace MVC_CORE_ModelBindingDemo.Controllers
{
    //Simple Binding Demo
    public class StudentController : Controller
    {
        //Simple Binding with QueryString Demo
        //localhost:1234/Student/Details?name=Ram&age=25
        public IActionResult Details(string name,int age)
        {
            return Content(" Name :"+name + ", Age : "+age);
        }

        //Simple Binding with Route Data
        // http://localhost:5152/user/1/prakash
        [Route("user/{id}/{name}")]
        public IActionResult Display(int id, string name)
        {
            return Content("User ID:"+ id+" Name:"+name);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
