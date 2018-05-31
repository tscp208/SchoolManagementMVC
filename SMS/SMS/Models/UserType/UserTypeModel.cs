using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS.Models.UserType
{
    public class UserTypeModel
    {
        public int UserTypeID { get; set; }

        [Required]
        [Display(Name = "User Type")]
        public string UserTypeName { get; set; }

        [Display(Name = "Description")]
        public string UserTypeDesc { get; set; }
    }

    public class UserTypeViewModel
    {
        public int UserTypeID { get; set; }

        [Display(Name = "Sr. No")]
        public int SrNo { get; set; }

        [Display(Name = "User Type")]
        public string UserTypeName { get; set; }

        [Display(Name = "Description")]
        public string UserTypeDesc { get; set; }
    }
}