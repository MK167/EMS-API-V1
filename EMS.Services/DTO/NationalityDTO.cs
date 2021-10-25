using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Services.DTO
{
    public class NationalityDTO
    {
        public Guid NationalityID { get; set; }
        public bool IsDeleted { get; set; } = false;

        
        public String NationalityName { get; set; }
    }
}
