using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IEventCategoryService
    {
        EventCategoryDTO GetEventCategoryByID(Guid ID);
        IEnumerable<EventCategoryDTO> GetAllEventCategorys();
        bool AddEventCategory(EventCategoryDTO Model, out string Message);
        bool UpdateEventCategory(EventCategoryDTO Model, out string Message);
        bool DeleteEventCategory(Guid EventCategoryID, out string Message);
    }
}
