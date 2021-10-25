using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IUserTypeService
    {
        UserTypeDTO GetUserTypeByID(Guid ID);
        IEnumerable<UserTypeDTO> GetAllUserTypes();
        bool AddUserType(UserTypeDTO Model, out string Message);
        bool UpdateUserType(UserTypeDTO Model, out string Message);
        bool DeleteUserType(Guid UserTypeID, out string Message);
    }
}
