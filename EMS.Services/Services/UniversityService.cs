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
    public class UniversityService : BaseService, IUniversityService
    {

        public UniversityService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddUniversity(UniversityDTO Model, out string Message)
        {
            var Entity = _mapper.Map<UniversityEntity>(Model);
            _unitofWork.UniversityRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }


        public bool DeleteUniversity(Guid UniversityID, out string Message)
        {
            var Entity = _unitofWork.UniversityRepository.FirstOrDefult(q => q.ID == UniversityID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<UniversityDTO> GetAllUniversitys()
        {
            var Entity = _unitofWork.UniversityRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<UniversityDTO>>(Entity);
            return EntityList;
        }

        public UniversityDTO GetUniversityByID(Guid ID)
        {
            var Entity = _unitofWork.UniversityRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<UniversityDTO>(Entity);
        }

        public bool UpdateUniversity(UniversityDTO Model, out string Message)
        {
            var Entity = _unitofWork.UniversityRepository.Get(Model.UniversityID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }

    }
}
