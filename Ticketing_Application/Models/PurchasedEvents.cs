using System;
using System.Collections.Generic;

namespace _665Project_ASP.Models
{
    public partial class PurchasedEvents
    {
        public int EventId { get; set; }
        public int UserId { get; set; }

        public virtual Events Event { get; set; }
        public virtual Users User { get; set; }
    }
}
