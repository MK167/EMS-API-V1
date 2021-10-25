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
    public class EventDetailsService : BaseService, IEventDetailsService
    {

        public EventDetailsService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddEventDetails(EventDetailsDTO Model, out string Message)
        {
            var Entity = _mapper.Map<EventDetailsEntity>(Model);
            _unitofWork.EventDetailsRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }

        public bool DeleteEventDetails(Guid EventDetailsID, out string Message)
        {
            var Entity = _unitofWork.EventDetailsRepository.FirstOrDefult(q => q.ID == EventDetailsID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<EventDetailsDTO> GetAllEventDetailss()
        {
            var Entity = _unitofWork.EventDetailsRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<EventDetailsDTO>>(Entity);
            return EntityList;
        }

        public EventDetailsDTO GetEventDetailsByID(Guid ID)
        {
            var Entity = _unitofWork.EventDetailsRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<EventDetailsDTO>(Entity);
        }

        public bool UpdateEventDetails(EventDetailsDTO Model, out string Message)
        {
            var Entity = _unitofWork.EventDetailsRepository.Get(Model.EventDetailsID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }
    }
}

