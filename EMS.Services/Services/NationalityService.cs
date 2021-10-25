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
    public class NationalityService : BaseService, INationalityService
    {

        public NationalityService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddNationality(NationalityDTO Model, out string Message)
        {
            var Entity = _mapper.Map<NationalityEntity>(Model);
            _unitofWork.NationalityRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }


        public bool DeleteNationality(Guid NationalityID, out string Message)
        {
            var Entity = _unitofWork.NationalityRepository.FirstOrDefult(q => q.ID == NationalityID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<NationalityDTO> GetAllNationalitys()
        {
            var Entity = _unitofWork.NationalityRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<NationalityDTO>>(Entity);
            return EntityList;
        }

        public NationalityDTO GetNationalityByID(Guid ID)
        {
            var Entity = _unitofWork.NationalityRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<NationalityDTO>(Entity);
        }

        public bool UpdateNationality(NationalityDTO Model, out string Message)
        {
            var Entity = _unitofWork.NationalityRepository.Get(Model.NationalityID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }

    }
}