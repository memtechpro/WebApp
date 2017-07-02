using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class MemberController : Controller
    {
        private ApplicationDbContext _context;

        public MemberController()
        {
            _context = new ApplicationDbContext();   
           
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Member
        public ActionResult Details(int id)
        {

            var member = _context.Members.SingleOrDefault(c=> c.id == id);
            

            if (member == null)
            {
                return HttpNotFound();
            }

            return View(member);

                     
            //return Content("Hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortbyname = "Name" });


        }

        public ActionResult Index()
        {
            var members = _context.Members.ToList();

            return View(members);
        }
    }
}