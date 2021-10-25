using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IGenderService
    {
        GenderDTO GetGenderByID(Guid ID);
        IEnumerable<GenderDTO> GetAllGenders();
        bool AddGender(GenderDTO Model, out string Message);
        bool UpdateGender(GenderDTO Model, out string Message);
        bool DeleteGender(Guid GenderID, out string Message);
    }
}