using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections;

namespace WebApp.Models
{
    public class Member
    {
      
        public string firstName { get; set; }
        [Required]
        [StringLength(30)]
        public string lastName { get; set; }
       
        public string Address { get; set; }
        public int id { get; set; }

        
    }
}