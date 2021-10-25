using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Interfaces
{
    public interface IJobService
    {
        JobDTO GetJobByID(Guid ID);
        IEnumerable<JobDTO> GetAllJobs();
        bool AddJob(JobDTO Model, out string Message);
        bool UpdateJob(JobDTO Model, out string Message);
        bool DeleteJob(Guid JobID, out string Message);
    }
}
