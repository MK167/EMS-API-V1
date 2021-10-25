using EMS.Entity.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Entity
{
    public class UserImageEntity : Base
    {

        [StringLength(900)]
        public string ImgPath { get; set; }

        public virtual ICollection<UserAdminEntity> UserAdmins { get; set; }

    }
}
