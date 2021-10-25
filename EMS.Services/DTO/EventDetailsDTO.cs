using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Services.DTO
{
    public class EventDetailsDTO
    {
        public Guid EventDetailsID { get; set; }
        public bool IsDeleted { get; set; } = false;

        public String EventDetailsName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public Guid OrganizerID { get; set; }
        public String OrganizerName { get; set; }

        public Guid EventStatusID { get; set; }
        
        public String EventStatusName { get; set; }

        public Guid EventVenueID { get; set; }
        
        public String EventVenueName { get; set; }

        public Guid EventCategoryID { get; set; }
        
        public String EventCategoryName { get; set; }

    }
}
