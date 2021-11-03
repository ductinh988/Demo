using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace netCore.Controllers
{
     public class HelloWorldController : Controller
    {
        //action index
        public IActionResult Index(){
            return View();
        }
         public IActionResult Demo(){
            return View();
         }
    }
}