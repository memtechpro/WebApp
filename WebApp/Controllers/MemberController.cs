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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Member member)
        {
            if (!ModelState.IsValid)
            {
                var memberModel = member;
                return View("MemberForm", memberModel);
            }
                     
            if (member.member_id == 0)                
            _context.Members.Add(member);                
            else
                {
                    var memberInDb = _context.Members.Single(c => c.member_id == member.member_id);

                memberInDb.member_full_name = member.member_full_name;
                memberInDb.member_nickname = member.member_nickname;
                memberInDb.member_email = member.member_email;
                memberInDb.member_age = member.member_age;
                memberInDb.member_address = member.member_address;
                memberInDb.member_city = member.member_city;
                memberInDb.member_country = member.member_country;
                memberInDb.member_postal_code = member.member_postal_code;
                memberInDb.member_telephone = member.member_telephone;
                memberInDb.member_sex = member.member_sex;
                memberInDb.member_additional_member_info = member.member_additional_member_info;

            }
            

            _context.SaveChanges();
            return RedirectToAction("Index", "Member");
        }

        public ActionResult New()
        {
            var member = new Member();
            return View("MemberForm", member);
        }

        public ActionResult Edit(int member_id)
        {
            var member = _context.Members.SingleOrDefault(c => c.member_id == member_id);
            return View("MemberForm", member);
        }

        public ActionResult Details(int member_id)
        {

            var member = _context.Members.SingleOrDefault(c=> c.member_id == member_id);
            
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