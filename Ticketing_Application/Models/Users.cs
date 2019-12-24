using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _665Project_ASP.Models
{
    public partial class Users
    {
        public Users()
        {
            Events = new HashSet<Events>();
            PurchasedEvents = new HashSet<PurchasedEvents>();
        }

        [Required(ErrorMessage = "Please enter a first name")]
        [MaxLength(20)]
        [RegularExpression(@"^[a-zA-Z-]+$", ErrorMessage = "First Name has invalid characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        [MaxLength(20)]
        [RegularExpression(@"^[a-zA-Z-]+$", ErrorMessage = "Last Name has invalid characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a Mobile Number")]
        [MaxLength(12)]
        [RegularExpression(@"^(\d{3}-)?\d{3}-\d{4}$", ErrorMessage = "Enter a valid Mobile Number")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Please enter a EmailId")]
        [MaxLength(50)]
        [RegularExpression(@"^[\w-\.]+@[\w]+\.[a-zA-Z]{2,4}$", ErrorMessage = "Enter a valid Email Id")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
       // [UIHint("password")]
        [MaxLength(10)]
        [RegularExpression(@"^[\w@\.-]+$", ErrorMessage = "Valid characters are a-z 0-9 _ . @ -")]
        public string Password { get; set; }
        public int UserId { get; set; }
        public int? UserRoleFk { get; set; }

        public virtual UserRole UserRoleFkNavigation { get; set; }
        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<PurchasedEvents> PurchasedEvents { get; set; }
    }
}
