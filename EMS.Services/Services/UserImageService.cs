using AutoMapper;
using EMS.DataAcess.UnitOfWork;
using EMS.Entity;
using EMS.Services.DTO;
using EMS.Services.Interfaces;
using EMS.Services.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Services
{
    public class UserImageService : BaseService, IUserImageService
    {

        public UserImageService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddUserImage(UserImageDTO Model, out string Message)
        {
            var Entity = _mapper.Map<UserImageEntity>(Model);
            _unitofWork.UserImageRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }


        public bool DeleteUserImage(Guid UserImageID, out string Message)
        {
            var Entity = _unitofWork.UserImageRepository.FirstOrDefult(q => q.ID == UserImageID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<UserImageDTO> GetAllUserImages()
        {
            var Entity = _unitofWork.UserImageRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<UserImageDTO>>(Entity);
            return EntityList;
        }

        public UserImageDTO GetUserImageByID(Guid ID)
        {
            var Entity = _unitofWork.UserImageRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<UserImageDTO>(Entity);
        }

        public bool UpdateUserImage(UserImageDTO Model, out string Message)
        {
            var Entity = _unitofWork.UserImageRepository.Get(Model.UserImageID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }

    }
}