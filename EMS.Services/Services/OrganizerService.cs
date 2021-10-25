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
    public class OrganizerService : BaseService, IOrganizerService
    {

        public OrganizerService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddOrganizer(OrganizerDTO Model, out string Message)
        {
            var Entity = _mapper.Map<OrganizerEntity>(Model);
            _unitofWork.OrganizerRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }


        public bool DeleteOrganizer(Guid OrganizerID, out string Message)
        {
            var Entity = _unitofWork.OrganizerRepository.FirstOrDefult(q => q.ID == OrganizerID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<OrganizerDTO> GetAllOrganizers()
        {
            var Entity = _unitofWork.OrganizerRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<OrganizerDTO>>(Entity);
            return EntityList;
        }

        public OrganizerDTO GetOrganizerByID(Guid ID)
        {
            var Entity = _unitofWork.OrganizerRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<OrganizerDTO>(Entity);
        }

        public bool UpdateOrganizer(OrganizerDTO Model, out string Message)
        {
            var Entity = _unitofWork.OrganizerRepository.Get(Model.OrganizerID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }

    }
}