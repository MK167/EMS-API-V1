using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Services.DTO
{
    public class EventAttendanceDTO
    {
        public Guid EventAttendanceID { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool ISAttend { get; set; } = false;


        public Guid UserAttendID { get; set; }
        [StringLength(250)]
        public string UserAttendName { get; set; }


        public Guid EventDetailsID { get; set; }
        [StringLength(250)]
        public string EventDetailsName { get; set; }


    }
}
