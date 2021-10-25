using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IEventDetailsService
    {
        EventDetailsDTO GetEventDetailsByID(Guid ID);
        IEnumerable<EventDetailsDTO> GetAllEventDetailss();
        bool AddEventDetails(EventDetailsDTO Model, out string Message);
        bool UpdateEventDetails(EventDetailsDTO Model, out string Message);
        bool DeleteEventDetails(Guid EventDetailsID, out string Message);
    }
}
