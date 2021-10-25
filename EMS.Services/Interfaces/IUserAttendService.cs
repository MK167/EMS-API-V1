using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IUserAttendService
    {
        UserAttendDTO GetUserAttendByID(Guid ID);
        IEnumerable<UserAttendDTO> GetAllUserAttends();
        bool AddUserAttend(UserAttendDTO Model, out string Message);
        bool UpdateUserAttend(UserAttendDTO Model, out string Message);
        bool DeleteUserAttend(Guid UserAttendID, out string Message);
    }
}
