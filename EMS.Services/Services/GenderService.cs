using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EMS.DataAcess.UnitOfWork;
using EMS.Entity;
using EMS.Services.DTO;
using EMS.Services.Interfaces;
using EMS.Services.Services.Base;

namespace EMS.Services.Services
{
    public class GenderService : BaseService, IGenderService
    {

        public GenderService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddGender(GenderDTO Model, out string Message)
        {
            var Entity = _mapper.Map<GenderEntity>(Model);
            _unitofWork.GenderRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }


        public bool DeleteGender(Guid GenderID, out string Message)
        {
            var Entity = _unitofWork.GenderRepository.FirstOrDefult(q => q.ID == GenderID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<GenderDTO> GetAllGenders()
        {
            var Entity = _unitofWork.GenderRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<GenderDTO>>(Entity);
            return EntityList;
        }

        public GenderDTO GetGenderByID(Guid ID)
        {
            var Entity = _unitofWork.GenderRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<GenderDTO>(Entity);
        }

        public bool UpdateGender(GenderDTO Model, out string Message)
        {
            var Entity = _unitofWork.GenderRepository.Get(Model.GenderID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }

    }
}