using EMS.Entity.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMS.Entity
{
    public class UserAttendEntity : Base
    {
        
        public String Title { get; set; }

        public String FullName { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Email { get; set; }

        
        public String Address { get; set; }

        public bool IsVIP { get; set; } = false;

        public Guid UniversityID { get; set; }
        [ForeignKey("UniversityID")]
        public virtual UniversityEntity University { get; set; }

        public Guid UserTypeID { get; set; }
        [ForeignKey("UserTypeID")]
        public virtual UserTypeEntity UserType { get; set; }

        public Guid NationalityID { get; set; }
        [ForeignKey("NationalityID")]
        public virtual NationalityEntity Nationality { get; set; }

        public Guid GenderID { get; set; }
        [ForeignKey("GenderID")]
        public virtual GenderEntity Gender { get; set; }


        public virtual ICollection<EventAttendanceEntity> EventAttendances { get; set; }

    }
}
