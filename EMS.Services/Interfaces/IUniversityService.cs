using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IUniversityService
    {
        UniversityDTO GetUniversityByID(Guid ID);
        IEnumerable<UniversityDTO> GetAllUniversitys();
        bool AddUniversity(UniversityDTO Model, out string Message);
        bool UpdateUniversity(UniversityDTO Model, out string Message);
        bool DeleteUniversity(Guid UniversityID, out string Message);
    }
}
