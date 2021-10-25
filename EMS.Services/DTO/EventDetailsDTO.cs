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

        [StringLength(250)]
        public string EventDetailsName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public Guid OrganizerID { get; set; }
        [StringLength(350)]
        public string OrganizerName { get; set; }

        public Guid EventStatusID { get; set; }
        [StringLength(350)]
        public string EventStatusName { get; set; }

        public Guid EventVenueID { get; set; }
        [StringLength(350)]
        public string EventVenueName { get; set; }

        public Guid EventCategoryID { get; set; }
        [StringLength(350)]
        public string EventCategoryName { get; set; }

    }
}
