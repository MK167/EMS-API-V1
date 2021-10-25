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
    public class EventVenueService : BaseService, IEventVenueService
    {

        public EventVenueService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddEventVenue(EventVenueDTO Model, out string Message)
        {
            var Entity = _mapper.Map<EventVenueEntity>(Model);
            _unitofWork.EventVenueRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }


        public bool DeleteEventVenue(Guid EventVenueID, out string Message)
        {
            var Entity = _unitofWork.EventVenueRepository.FirstOrDefult(q => q.ID == EventVenueID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<EventVenueDTO> GetAllEventVenues()
        {
            var Entity = _unitofWork.EventVenueRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<EventVenueDTO>>(Entity);
            return EntityList;
        }

        public EventVenueDTO GetEventVenueByID(Guid ID)
        {
            var Entity = _unitofWork.EventVenueRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<EventVenueDTO>(Entity);
        }

        public bool UpdateEventVenue(EventVenueDTO Model, out string Message)
        {
            var Entity = _unitofWork.EventVenueRepository.Get(Model.EventVenueID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }

    }
}