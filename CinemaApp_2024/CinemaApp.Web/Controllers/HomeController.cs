namespace CinemaApp.Web.Controllers
{

    using System.Diagnostics;    // System Namespaces

    using Microsoft.AspNetCore.Mvc;   // Third-Party Namespaces

    using ViewModels;    //  Internal Project Namespaces


    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Home Page";
            ViewData["Message"] = "Welcome to the Cinema Web App!";

            return View();
        }

       
    }
}
