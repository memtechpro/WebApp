using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;

namespace WebApp.Controllers.API
{
    public class MembersController : ApiController
    {
        private ApplicationDbContext _context;

        public MembersController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/members
        public IEnumerable<Member> GetMembers()
        {
            return _context.Members.ToList();
        }
        //GET /api/members/1
        [HttpGet]
        public Member GetMember(int member_id)
        {
            var member = _context.Members.SingleOrDefault(c => c.member_id == member_id);
            if (member == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return member;
        }
        //POST /api/members
        [HttpPost]
        public Member CreateMember(Member member)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Members.Add(member);
            _context.SaveChanges();
            return member;
        }

        //PUT /api/members/1
        [HttpPut]
        public void UpdateMember(int member_id, Member member)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var memberInDb = _context.Members.SingleOrDefault(c => c.member_id == member_id);
            if (memberInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            memberInDb.member_full_name = member.member_full_name;
            
            memberInDb.member_address = member.member_address;

            _context.SaveChanges();
        }
        //DELETE api/members/1
        [HttpDelete]
        public void DeleteMember(int member_id)
        {
            var memberInDb = _context.Members.SingleOrDefault(c => c.member_id == member_id);
            if (memberInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Members.Remove(memberInDb);
            _context.SaveChanges();

        }
    }
}
