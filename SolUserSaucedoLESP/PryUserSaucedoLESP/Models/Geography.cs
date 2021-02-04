using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PryUserSaucedoLESP.Models
{
    public class Geography
    {
        [Key]
        [Required]
        public string Lat { get; set; }
        [Required]
        public string Lng { get; set; }

    }
}