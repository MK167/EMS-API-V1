using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Services.DTO
{
    public class JobDTO
    {
        public Guid JobID { get; set; }
        public bool IsDeleted { get; set; } = false;

        [StringLength(250)]
        public string jobName { get; set; }
    }
}
