using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IEventStatusService
    {
        EventStatusDTO GetEventStatusByID(Guid ID);
        IEnumerable<EventStatusDTO> GetAllEventStatuss();
        bool AddEventStatus(EventStatusDTO Model, out string Message);
        bool UpdateEventStatus(EventStatusDTO Model, out string Message);
        bool DeleteEventStatus(Guid EventStatusID, out string Message);
    }
}
