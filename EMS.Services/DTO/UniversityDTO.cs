using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Services.DTO
{
    public class UniversityDTO
    {
        public Guid UniversityID { get; set; }
        public bool IsDeleted { get; set; } = false;

        
        public String UniversityName { get; set; }
    }
}
