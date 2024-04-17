using BibotifyApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibotifyApp.Controllers
{
    public class BibotifyController : Controller
    {
        public IActionResult Index()
        {
            BibotifyViewModel Main = new BibotifyViewModel
            {
                Kategoriler = Fabrika.Kategoriler,
                Sarkılar = Fabrika.Sarkılar.Where(s => s.EnCokDinlenenMi == true).ToList()
            };
            return View(Main);
        }
        public IActionResult listele()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Sarki(int? id)
        {
            if (id != null)
            {
                var sarkilar = Fabrika.Sarkılar.FirstOrDefault(s => s.Id == id);
                return View(sarkilar);
            }
            return RedirectToAction("Index");
        }
    }
}
