
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace _665Project_ASP.Models
{
    public class AdminLoginInput
    {
        [Required(ErrorMessage = "Please enter a email")]
        [MaxLength(50)]
        public string AdminId { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [UIHint("password")]
        [MaxLength(50)]
        public string Password { get; set; }

        public string ReturnURL { get; set; }
    }
}

