using EMS.Entity.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace EMS.Entity
{
    public class EventAttendanceEntity : Base
    {
        public Guid UserAttendID { get; set; }
        [ForeignKey("UserAttendID")]
        public virtual UserAttendEntity UserAttend { get; set; }


        public Guid EventDetailsID { get; set; }
        [ForeignKey("EventDetailsID")]
        public virtual EventDetailsEntity EventDetails { get; set; }

        public bool ISAttend { get; set; } = false;
    }
}
