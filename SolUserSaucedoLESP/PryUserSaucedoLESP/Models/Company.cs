using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PryUserSaucedoLESP.Models
{
    public class Company
    {
        [Key]
        [Required]
        public string name { get; set; }
        [Required]
        public string cathphrase { get; set; }

    }
}