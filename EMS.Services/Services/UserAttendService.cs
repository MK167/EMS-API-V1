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
    public class UserAttendService : BaseService, IUserAttendService
    {

        public UserAttendService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddUserAttend(UserAttendDTO Model, out string Message)
        {
            var Entity = _mapper.Map<UserAttendEntity>(Model);
            _unitofWork.UserAttendRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }


        public bool DeleteUserAttend(Guid UserAttendID, out string Message)
        {
            var Entity = _unitofWork.UserAttendRepository.FirstOrDefult(q => q.ID == UserAttendID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<UserAttendDTO> GetAllUserAttends()
        {
            var Entity = _unitofWork.UserAttendRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<UserAttendDTO>>(Entity);
            return EntityList;
        }

        public UserAttendDTO GetUserAttendByID(Guid ID)
        {
            var Entity = _unitofWork.UserAttendRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<UserAttendDTO>(Entity);
        }

        public bool UpdateUserAttend(UserAttendDTO Model, out string Message)
        {
            var Entity = _unitofWork.UserAttendRepository.Get(Model.UserAttendID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }

    }
}