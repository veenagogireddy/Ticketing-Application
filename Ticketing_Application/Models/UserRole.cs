using System;
using System.Collections.Generic;

namespace _665Project_ASP.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            Users = new HashSet<Users>();
        }

        public int UserRolePk { get; set; }
        public string UserRoleName { get; set; }
        public string UserRoleDescription { get; set; }
        public string UserType { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
