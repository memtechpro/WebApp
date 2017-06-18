using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Members()
        {
            var member = new Member() { firstName = "John" };
            return View(member);
            //return Content("Hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortbyname = "Name" });

            
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}