using EMS.Entity.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Entity
{
    public class UniversityEntity : Base
    {
        [StringLength(450)]

        public string Name { get; set; }

        public virtual ICollection<UserAttendEntity> UserAttends { get; set; }

    }
}
