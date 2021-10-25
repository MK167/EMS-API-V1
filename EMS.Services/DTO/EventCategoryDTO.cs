using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Services.DTO
{
    public class EventCategoryDTO
    {
        [StringLength(350)]
        public Guid EventCategoryID { get; set; }
        public bool IsDeleted { get; set; } = false;

        public string EventCategoryName { get; set; }
    }
}
