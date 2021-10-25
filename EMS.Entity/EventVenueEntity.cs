using EMS.Entity.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Entity
{
    public class EventVenueEntity : Base
    {

        public String Name { get; set; }

        public virtual ICollection<EventDetailsEntity> EventDetails { get; set; }

    }
}
