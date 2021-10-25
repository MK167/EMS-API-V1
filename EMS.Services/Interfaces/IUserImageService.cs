using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IUserImageService
    {
        UserImageDTO GetUserImageByID(Guid ID);
        IEnumerable<UserImageDTO> GetAllUserImages();
        bool AddUserImage(UserImageDTO Model, out string Message);
        bool UpdateUserImage(UserImageDTO Model, out string Message);
        bool DeleteUserImage(Guid UserImageID, out string Message);

    }
}
