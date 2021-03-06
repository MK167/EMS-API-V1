using EMS.Entity.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Entity
{
    public class GenderEntity : Base
    {

        public String Name { get; set; }

        public virtual ICollection<UserAttendEntity> UserAttends { get; set; }

    }
}
