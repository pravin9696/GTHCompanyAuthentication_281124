using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GTHCompanyAuthentication_281124.Models.validation_Data
{
    public class loginClass
    {
        public int id { get; set; }
        [Required]
        public string userid { get; set; }
        [Required]
        public string password { get; set; }       
        
        public string Repassword { get; set; }
        public bool save { set; get; }
    }
}