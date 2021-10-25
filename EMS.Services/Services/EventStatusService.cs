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
    public class EventStatusService : BaseService, IEventStatusService
    {

        public EventStatusService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddEventStatus(EventStatusDTO Model, out string Message)
        {
            var Entity = _mapper.Map<EventStatusEntity>(Model);
            _unitofWork.EventStatusRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }

        public bool DeleteEventStatus(Guid EventStatusID, out string Message)
        {
            var Entity = _unitofWork.EventStatusRepository.FirstOrDefult(q => q.ID == EventStatusID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<EventStatusDTO> GetAllEventStatuss()
        {
            var Entity = _unitofWork.EventStatusRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<EventStatusDTO>>(Entity);
            return EntityList;
        }

        public EventStatusDTO GetEventStatusByID(Guid ID)
        {
            var Entity = _unitofWork.EventStatusRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<EventStatusDTO>(Entity);
        }

        public bool UpdateEventStatus(EventStatusDTO Model, out string Message)
        {
            var Entity = _unitofWork.EventStatusRepository.Get(Model.EventStatusID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }
    }
}

