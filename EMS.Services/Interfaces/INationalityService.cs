using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface INationalityService
    {
        NationalityDTO GetNationalityByID(Guid ID);
        IEnumerable<NationalityDTO> GetAllNationalitys();
        bool AddNationality(NationalityDTO Model, out string Message);
        bool UpdateNationality(NationalityDTO Model, out string Message);
        bool DeleteNationality(Guid NationalityID, out string Message);
    }
}
