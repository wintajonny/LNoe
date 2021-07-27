using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationWithASPNETCore.Models
{
    public class UserRegistration
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
