using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppBootstrap.Models;

namespace AppBootstrap.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //переходим на главную страницу
        public ActionResult mainPage() {
            return View("Index");
        }
        //переходим на страницу фильмы
        public ActionResult filmsShow() {
            return View("Show");
        }
        //переходим на страницу контакты
        public ActionResult pageContacts() {
            return View("Contacts");
        }
        //переходим на страницу сериалы
        public ActionResult pageSerials() {
            return View("Serials");
        }
        //переходим на страницу рейтинг фильмов
        public ActionResult pageRating() {
            return View("Rating");
        }
    }
}
