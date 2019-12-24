using System;
using System.Collections.Generic;

namespace _665Project_ASP.Models
{
    public partial class Admin
    {
        public string AdminId { get; set; }
        public string Password { get; set; }

        public int? UserRoleFk { get; set; }
    }
}
