using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IUserAdminService
    {
        UserAdminDTO GetUserAdminByID(Guid ID);
        IEnumerable<UserAdminDTO> GetAllUserAdmins();
        bool AddUserAdmin(UserAdminDTO Model, out string Message);
        bool UpdateUserAdmin(UserAdminDTO Model, out string Message);
        bool DeleteUserAdmin(Guid UserAdminID, out string Message);
    }
}
