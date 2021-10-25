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

        [StringLength(250)]
        public string NationalityName { get; set; }
    }
}
