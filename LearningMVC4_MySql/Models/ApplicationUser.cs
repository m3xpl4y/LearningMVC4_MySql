using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningMVC4_MySql.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(60)]
        [Display(Name ="Vorname")]
        public string FirstName { get; set; }
    }
}
