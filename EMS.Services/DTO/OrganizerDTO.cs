using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Services.DTO
{
    public class OrganizerDTO
    {
        public Guid OrganizerID { get; set; }
        public bool IsDeleted { get; set; } = false;

        [StringLength(250)]
        public string OrganizerName { get; set; }
    }
}
