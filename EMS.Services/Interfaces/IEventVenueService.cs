using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IEventVenueService
    {
        EventVenueDTO GetEventVenueByID(Guid ID);
        IEnumerable<EventVenueDTO> GetAllEventVenues();
        bool AddEventVenue(EventVenueDTO Model, out string Message);
        bool UpdateEventVenue(EventVenueDTO Model, out string Message);
        bool DeleteEventVenue(Guid EventVenueID, out string Message);
    }
}
