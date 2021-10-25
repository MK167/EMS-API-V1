using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IOrganizerService
    {
        OrganizerDTO GetOrganizerByID(Guid ID);
        IEnumerable<OrganizerDTO> GetAllOrganizers();
        bool AddOrganizer(OrganizerDTO Model, out string Message);
        bool UpdateOrganizer(OrganizerDTO Model, out string Message);
        bool DeleteOrganizer(Guid OrganizerID, out string Message);
    }
}
