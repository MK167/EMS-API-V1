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
    public class EventAttendanceService : BaseService, IEventAttendanceService
    {
        public EventAttendanceService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public bool AddEventAttendance(EventAttendanceDTO Model, out string Message)
        {
            var Entity = _mapper.Map<EventAttendanceEntity>(Model);
            _unitofWork.EventAttendanceRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }

        public bool DeleteEventAttendance(Guid EventAttendanceID, out string Message)
        {
            var Entity = _unitofWork.EventAttendanceRepository.FirstOrDefult(q => q.ID == EventAttendanceID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<EventAttendanceDTO> GetAllEventAttendances()
        {
            var Entity = _unitofWork.EventAttendanceRepository.Find(c => c.IsDeleted == false, include: source => source
          .Include(i => i.EventDetails)
          .Include(k => k.UserAttend));

            var EntityList = _mapper.Map<IEnumerable<EventAttendanceDTO>>(Entity);
            return EntityList;
        }

        public EventAttendanceDTO GetEventAttendanceByID(Guid ID)
        {
            var Entity = _unitofWork.EventAttendanceRepository.FirstOrDefult(x => x.ID == ID, include: source => source
          .Include(i => i.EventDetails)
          .Include(k => k.UserAttend));
            return _mapper.Map<EventAttendanceDTO>(Entity);
        }

        public bool UpdateEventAttendance(EventAttendanceDTO Model, out string Message)
        {
            var Entity = _unitofWork.EventAttendanceRepository.Get(Model.EventAttendanceID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }
    }
}
