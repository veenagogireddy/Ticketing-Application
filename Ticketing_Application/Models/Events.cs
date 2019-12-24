using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _665Project_ASP.Models
{
    public partial class Events
    {
        public Events()
        {
            PurchasedEvents = new HashSet<PurchasedEvents>();
        }

        public int EventId { get; set; }

        [Required(ErrorMessage = "Please enter a event name")]
        [MaxLength(25)]
        public string EventName { get; set; }

        [Required(ErrorMessage = "Please enter event venue")]
        [MaxLength(25)]
        public string EventVenue { get; set; }

        [Required(ErrorMessage = "Please enter event duration")]
        [Range(1,100)]
        public int EventDuration { get; set; }

    

        public DateTime EventDate { get; set; }
        public string EventStatus { get; set; }
        public int EventOrganizerId { get; set; }

        [Required(ErrorMessage = "Please enter event type")]
        [MaxLength(25)]
        public string EventType { get; set; }

        [Required(ErrorMessage = "Please select event city")]
        public string EventCity { get; set; }

        [Required(ErrorMessage = "Please enter event zip")]
      

        public int EventZip { get; set; }

        [Required(ErrorMessage = "Please enter event description")]
     
        public string EventDescription { get; set; }

        [Required(ErrorMessage = "Please enter event start time(24 hours format)")]
        [MaxLength(10)]
        [RegularExpression(@"([01]?[0-9]|2[0-3]):[0-5][0-9]", ErrorMessage = "Event start time should be in the format XX:XX")]
        public string EventStartTime { get; set; }

        public virtual Users EventOrganizer { get; set; }
        public virtual ICollection<PurchasedEvents> PurchasedEvents { get; set; }
    }
}
