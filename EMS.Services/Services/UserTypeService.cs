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
    public class UserTypeService : BaseService, IUserTypeService
    {

        public UserTypeService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddUserType(UserTypeDTO Model, out string Message)
        {
            var Entity = _mapper.Map<UserTypeEntity>(Model);
            _unitofWork.UserTypeRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }


        public bool DeleteUserType(Guid UserTypeID, out string Message)
        {
            var Entity = _unitofWork.UserTypeRepository.FirstOrDefult(q => q.ID == UserTypeID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<UserTypeDTO> GetAllUserTypes()
        {
            var Entity = _unitofWork.UserTypeRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<UserTypeDTO>>(Entity);
            return EntityList;
        }

        public UserTypeDTO GetUserTypeByID(Guid ID)
        {
            var Entity = _unitofWork.UserTypeRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<UserTypeDTO>(Entity);
        }

        public bool UpdateUserType(UserTypeDTO Model, out string Message)
        {
            var Entity = _unitofWork.UserTypeRepository.Get(Model.UserTypeID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }

    }
}