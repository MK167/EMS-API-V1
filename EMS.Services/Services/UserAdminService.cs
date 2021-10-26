using AutoMapper;
using EMS.DataAcess.UnitOfWork;
using EMS.Entity;
using EMS.Services.DTO;
using EMS.Services.Interfaces;
using EMS.Services.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Services
{
    public class UserAdminService : BaseService, IUserAdminService
    {

        public UserAdminService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddUserAdmin(UserAdminDTO Model, out string Message)
        {
            var Entity = _mapper.Map<UserAdminEntity>(Model);
            _unitofWork.UserAdminRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }


        public bool DeleteUserAdmin(Guid UserAdminID, out string Message)
        {
            var Entity = _unitofWork.UserAdminRepository.FirstOrDefult(q => q.ID == UserAdminID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<UserAdminDTO> GetAllUserAdmins()
        {
            var Entity = _unitofWork.UserAdminRepository.Find(c => c.IsDeleted == false, include: source => source
           .Include(i => i.Job)
           .Include(k => k.UsrerImage));

            var EntityList = _mapper.Map<IEnumerable<UserAdminDTO>>(Entity);
            return EntityList;
        }

        public UserAdminDTO GetUserAdminByID(Guid ID)
        {
            var Entity = _unitofWork.UserAdminRepository.FirstOrDefult(x => x.ID == ID, include: source => source
          .Include(i => i.Job)
          .Include(k => k.UsrerImage));

            return _mapper.Map<UserAdminDTO>(Entity);
        }

        public bool UpdateUserAdmin(UserAdminDTO Model, out string Message)
        {
            var Entity = _unitofWork.UserAdminRepository.Get(Model.UserAdminID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }

    }
}
