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
    public class EventCategoryService : BaseService, IEventCategoryService
    {
        public EventCategoryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public bool AddEventCategory(EventCategoryDTO Model, out string Message)
        {
            var Entity = _mapper.Map<EventCategoryEntity>(Model);
            _unitofWork.EventCategoryRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }

        public bool DeleteEventCategory(Guid EventCategoryID, out string Message)
        {
            var Entity = _unitofWork.EventCategoryRepository.FirstOrDefult(q => q.ID == EventCategoryID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<EventCategoryDTO> GetAllEventCategorys()
        {
            var Entity = _unitofWork.EventCategoryRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<EventCategoryDTO>>(Entity);
            return EntityList;
        }

        public EventCategoryDTO GetEventCategoryByID(Guid ID)
        {
            var Entity = _unitofWork.EventCategoryRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<EventCategoryDTO>(Entity);
        }

        public bool UpdateEventCategory(EventCategoryDTO Model, out string Message)
        {
            var Entity = _unitofWork.EventCategoryRepository.Get(Model.EventCategoryID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }
    }
}
