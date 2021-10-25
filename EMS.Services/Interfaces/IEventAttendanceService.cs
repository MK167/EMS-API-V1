using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IEventAttendanceService
    {
        EventAttendanceDTO GetEventAttendanceByID(Guid ID);
        IEnumerable<EventAttendanceDTO> GetAllEventAttendances();
        bool AddEventAttendance(EventAttendanceDTO Model, out string Message);
        bool UpdateEventAttendance(EventAttendanceDTO Model, out string Message);
        bool DeleteEventAttendance(Guid EventAttendanceID, out string Message);
    }
}
