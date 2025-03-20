using Microsoft.AspNetCore.Mvc;

namespace BeckonPurses.Controllers
{
    public class HelloWorldController : Controller
    {
        // Comment the below code for future purpose

        // 
        // GET: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // Comment the below code for future purpose

        // 
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int ID = 1)
        //{
        //    //return "This is the Welcome action method...";
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID : {ID}");
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
