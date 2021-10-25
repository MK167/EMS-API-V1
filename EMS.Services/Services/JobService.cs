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
    public class JobService : BaseService, IJobService
    {

        public JobService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool AddJob(JobDTO Model, out string Message)
        {
            var Entity = _mapper.Map<JobEntity>(Model);
            _unitofWork.JobRepository.Add(Entity);
            _unitofWork.Complete();
            Message = "تم اضافة عنصر جديد بنجاح ";
            return true;
        }


        public bool DeleteJob(Guid JobID, out string Message)
        {
            var Entity = _unitofWork.JobRepository.FirstOrDefult(q => q.ID == JobID);
            Entity.IsDeleted = true;
            _unitofWork.Complete();
            Message = "تم الحذف بنجاح";
            return true;
        }

        public IEnumerable<JobDTO> GetAllJobs()
        {
            var Entity = _unitofWork.JobRepository.Find(c => c.IsDeleted == false);
            var EntityList = _mapper.Map<IEnumerable<JobDTO>>(Entity);
            return EntityList;
        }

        public JobDTO GetJobByID(Guid ID)
        {
            var Entity = _unitofWork.JobRepository.FirstOrDefult(x => x.ID == ID);
            return _mapper.Map<JobDTO>(Entity);
        }

        public bool UpdateJob(JobDTO Model, out string Message)
        {
            var Entity = _unitofWork.JobRepository.Get(Model.JobID);
            _mapper.Map(Model, Entity);
            _unitofWork.Complete();
            Message = "تم تحديث البيانات بنجاح";
            return true;
        }

    }
}
