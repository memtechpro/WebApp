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
        [Key]
        public int member_id { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please Enter Full Name")]
        [StringLength(30)]
        public string member_full_name { get; set; }

        [Display(Name = "Nick Name")]        
        [StringLength(30)]
        public string member_nickname { get; set; }

        [Display(Name = "Email")]       
        [StringLength(30)]
        public string member_email { get; set; }

        [Display(Name = "Age")]        
        [StringLength(50)]
        public string member_age{ get; set; }

        [Display(Name = "Address")]
        
        [StringLength(50)]
        public string member_address { get; set; }

        [Display(Name = "City")]
        [StringLength(50)]
        public string member_city { get; set; }

        [Display(Name = "Country")]
        [StringLength(50)]
        public string member_country { get; set; }

        [Display(Name = "Postal Code")]
        [StringLength(50)]
        public string member_postal_code { get; set; }

        [Display(Name = "Telephone")]       
        [StringLength(15)]
        public string member_telephone { get; set; }

        [Display(Name = "Sex")]        
        [StringLength(10)]
        public string member_sex { get; set; }


        [Display(Name = "Additional Member Info")]
        [StringLength(50)]
        public string member_additional_member_info { get; set; }


    }
}