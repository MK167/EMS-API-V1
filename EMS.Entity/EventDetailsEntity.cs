using EMS.Entity.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMS.Entity
{
    public class EventDetailsEntity : Base
    {
        [StringLength(250)]

        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }


        public Guid OrganizerID { get; set; }
        [ForeignKey("OrganizerID")]
        public virtual OrganizerEntity Organizer { get; set; }

        public Guid EventStatusID { get; set; }
        [ForeignKey("EventStatusID")]
        public virtual EventStatusEntity EventStatus { get; set; }

        public Guid EventVenueID { get; set; }
        [ForeignKey("EventVenueID")]
        public virtual EventVenueEntity EventVenue { get; set; }

        public Guid EventCategoryID { get; set; }
        [ForeignKey("EventCategoryID")]
        public virtual EventCategoryEntity EventCategory { get; set; }


        public virtual ICollection<EventAttendanceEntity> EventAttendances { get; set; }
    }
}
