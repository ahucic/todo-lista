using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using assignmentWork.Models;

namespace assignmentWork.Controllers
{
    public class WelcomeController : Controller
    {
        private readonly Datadb _context;

        public WelcomeController(Datadb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Register tb)
        {
            _context.regtb.Add(tb);
            _context.SaveChanges();
            ViewBag.message = "Registracija uspjela";
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Register tb)
        {
            var login = _context.regtb.Where(x => x.user_email == tb.user_email && x.user_password == tb.user_password).FirstOrDefault();
            if (login!=null)
            {
                return RedirectToAction("welcome");

            }else if (!(login != null))
            {
                ViewBag.success = "Nevažeći podaci";

            }
            return View();
        }
        public IActionResult welcome()
        {
            return View();
        }
        [HttpGet]
        public IActionResult welcome(Register tb)
        {
            var cc = _context.listtb.ToList();
            var list = (from c in cc select new Class {id=c.id, name=c.name });
            ViewBag.select = list;
            return View();
        }
        [HttpPost]
        public IActionResult welcome(list tb)
        {
            //var cc = _context.listtb.ToList();
            _context.listtb.Add(tb);
            _context.SaveChanges();
            return RedirectToAction("welcome");
        }
        [HttpPost]
        public IActionResult delete(list tb, int[] id)
        {
            foreach (int item in id)
            {
                var find = _context.listtb.Where(x => x.id == item).FirstOrDefault();
                _context.listtb.Remove(find);
               
            }
            _context.SaveChanges();
            return RedirectToAction("welcome");
            //var cc = _context.listtb.ToList();

            return RedirectToAction("welcome");
        }





    }
}