using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Dto
{
    public class MemberDto
    {
       
        [StringLength(30)]
        public string firstName { get; set; }

        
        [StringLength(30)]
        public string lastName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }
        public int id { get; set; }
    }
}